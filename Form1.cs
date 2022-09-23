using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_Drawer
{
    public partial class Form1 : Form
    {
        Canvas my_canvas;
        UndoRedo undoRedo;

        private MouseState mouseState;

        private Figure drawn = null;
        Color cur_color;
        Dictionary<string, Creator> fig_dict;
        Creator creator;
        public Form1()
        {
            InitializeComponent();
            my_canvas = new Canvas();
            undoRedo = new UndoRedo(my_canvas);
            undoRedo.SetStateForUndoRedo();

            Line.LineCreator lineCreator = new Line.LineCreator();
            Circle.CircleCreator circleCreator = new Circle.CircleCreator();
            Rectangle.RectCreator rectCreator = new Rectangle.RectCreator();
            creator = rectCreator;
            fig_dict = new Dictionary<string, Creator> { { "select", null }, { "line", lineCreator }, { "circle", circleCreator }, { "rect", rectCreator } };


            mouseState = new MouseState();

            cur_color = Color.Black;

            handleToolChange("rect");
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            creator = fig_dict[tag];
            handleToolChange(tag);
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseState.SX = e.X;
            mouseState.SY = e.Y;
            mouseState.Pressed = true;

            if (!mouseState.Pressed) return;
            if (creator!=null)
            {
                drawn = creator.Create(mouseState.SX, mouseState.SY, (mouseState.EX - mouseState.SX), (mouseState.EY - mouseState.SY));
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouseState.EX = e.X;
            mouseState.EY = e.Y;

            if (!mouseState.Pressed) return;
            if (creator != null)
            {
                drawn = creator.Create(mouseState.SX, mouseState.SY, (mouseState.EX - mouseState.SX), (mouseState.EY - mouseState.SY));
            }
            canvas.Refresh();
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawn != null)
                my_canvas.Add(drawn);

            drawn = null;
            mouseState.Reset();
            undoRedo.SetStateForUndoRedo();
        }
        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            //switch (menuItem)
            //{
            //    case MenuItem.Select:
            //        bool found = false;

            //        foreach (Figure figure in figures)
            //        {
            //            if (figure.GetType() == typeof(Rectangle))
            //            {
            //                Rectangle f = (Rectangle)figure;
            //                if (!found && e.X >= f.x && e.X <= (f.x + f.width) && e.Y >= f.y && e.Y <= (f.y + f.height))
            //                {
            //                    figure.selected = true;
            //                    found = true;
            //                }
            //                else
            //                    figure.selected = false;
            //            }

            //            if (figure.GetType() == typeof(Circle))
            //            {
            //                Circle f = (Circle)figure;
            //                if (!found && e.X >= f.x && e.X <= (f.x + f.width) && e.Y >= f.y && e.Y <= (f.y + f.height))
            //                {
            //                    figure.selected = true;
            //                    found = true;
            //                }
            //                else
            //                    figure.selected = false;
            //            }
            //        }
            //        break;
            //    case MenuItem.Line:
            //        break;
            //    case MenuItem.Circle:
            //        break;
            //    case MenuItem.Rectangle:
            //        break;
            //    case MenuItem.Fill:
            //        break;
            //    case MenuItem.Erase:
            //        break;
            //    default:
            //        break;

            //}            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //g.Clear(Color.White);
            //canvas.Image = bm;
            //index = 0;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //saveFileDialog.ShowDialog();
            //saveFileDialog.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    Bitmap btm = bm.Clone(new Rectangle(0, 0, canvas.Width, canvas.Height), bm.PixelFormat);
            //    btm.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            //}
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            try
            {
                if (drawn != null)
                    drawn.Draw(g, cur_color);

                foreach (Figure figure in my_canvas.Figures)
                    figure.Draw(g, cur_color);
            }
            catch { }
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            cur_color = cd.Color;
            colorBtn.BackColor = cur_color;
        }

        private void handleToolChange(string tag)
        {
            pointerBtn.BackColor = panel1.BackColor;
            lineBtn.BackColor = panel1.BackColor;
            circleBtn.BackColor = panel1.BackColor;
            squareBtn.BackColor = panel1.BackColor;
            fillBtn.BackColor = panel1.BackColor;
            eraserBtn.BackColor = panel1.BackColor;

            var item = panel1.Controls.Cast<Control>().FirstOrDefault(control => String.Equals(control.Tag, tag));
            item.BackColor = Color.Yellow;
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            undoRedo.Undo(1);
            canvas.Refresh();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            undoRedo.Redo(1);
            canvas.Refresh();
        }
    }
}
