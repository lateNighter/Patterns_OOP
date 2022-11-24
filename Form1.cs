using Patterns_Drawer.Command;
using Patterns_Drawer.CommandGroup;
using Patterns_Drawer.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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
        Dictionary<string, Creator> creator_dict;
        Dictionary<string, ICommand> command_dict;
        Dictionary<string, IGroupCommand> group_dict;
        Creator creator;
        ICommand command;
        IGroupCommand groupCommand;
        public Form1()
        {
            InitializeComponent();
            my_canvas = new Canvas();
            undoRedo = new UndoRedo(my_canvas);
            undoRedo.SetStateForUndoRedo();

            Line.LineCreator lineCreator = new Line.LineCreator();
            Circle.CircleCreator circleCreator = new Circle.CircleCreator();
            Rectangle.RectCreator rectCreator = new Rectangle.RectCreator();

            SelectCommand selectCommand = new SelectCommand();
            MoveCommand moveCommand = new MoveCommand();
            FillCommand fillCommand = new FillCommand();
            ResizeCommand plusCommand = new ResizeCommand(10);
            ResizeCommand minusCommand = new ResizeCommand(-10);
            RemoveCommand removeCommand = new RemoveCommand(my_canvas);
            AddTextCommand addTextCommand = new AddTextCommand();

            AddToGroupCommand addToGroupCommand = new AddToGroupCommand();

            creator = rectCreator;

            creator_dict = new Dictionary<string, Creator> { { "line", lineCreator }, { "circle", circleCreator }, { "rect", rectCreator } };
            command_dict = new Dictionary<string, ICommand> { { "select", selectCommand }, { "move", moveCommand }, { "fill", fillCommand }, { "plus", plusCommand }, { "minus", minusCommand }, { "erase", removeCommand }, { "text", addTextCommand } };
            group_dict = new Dictionary<string, IGroupCommand> { { "group", addToGroupCommand } };

            mouseState = new MouseState();

            cur_color = colorBtn.BackColor;

            handleToolChange("rect");
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            creator = creator_dict[tag];
            handleToolChange(tag);
            command = null;
            groupCommand = null;
        }
        private void commandBtn_Click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            command = command_dict[tag];
            handleToolChange(tag);
            creator = null;
            groupCommand = null;
        }
        private void groupBtn_Click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            groupCommand = group_dict[tag];
            handleToolChange(tag);
            creator = null;
            command = null;
        }
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseState.SX = e.X;
            mouseState.SY = e.Y;
            mouseState.Pressed = true;

            if (creator!=null)
            {
                drawn = creator.Create(mouseState.SX, mouseState.SY, (mouseState.EX - mouseState.SX), (mouseState.EY - mouseState.SY));
            }

            if (groupCommand != null)
            {
                groupCommand.SetStatus(new List<object> { mouseState.SX, mouseState.SY });
                groupCommand.Execute(my_canvas);
                canvas.Refresh();
                undoRedo.SetStateForUndoRedo();
            }

            if (command != null)
            {
                command.SetStatus(new List<object> { mouseState.SX, mouseState.SY, cur_color, textBox1.Text, my_canvas });
                //for (int i = 0; i < my_canvas.Figures.Count; i++)
                //{
                //    command.Execute(my_canvas.Figures[i]);
                //}
                foreach (Figure figure in my_canvas.Figures.ToArray())//
                {
                    command.Execute(figure);
                }
                //my_canvas.Figures[0] = new TextDecorator(my_canvas.Figures[0], "dhfghjkj");
                canvas.Refresh();
                undoRedo.SetStateForUndoRedo();
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseState.Pressed) return;

            mouseState.EX = e.X;
            mouseState.EY = e.Y;

            if (creator != null)
            {
                drawn = creator.Create(mouseState.SX, mouseState.SY, (mouseState.EX - mouseState.SX), (mouseState.EY - mouseState.SY));
            }
            canvas.Refresh();
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawn != null)
            {
                my_canvas.Add(drawn);
                undoRedo.SetStateForUndoRedo();
            }
                

            drawn = null;
            mouseState.Reset();
        }


        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            try
            {
                if (drawn != null)
                    drawn.Draw(g, cur_color);

                foreach (Figure figure in my_canvas.Figures)
                    figure.Draw(g, figure.color);//cur_color
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
            moveBtn.BackColor = panel1.BackColor;
            groupBtn.BackColor = panel1.BackColor;

            lineBtn.BackColor = panel1.BackColor;
            circleBtn.BackColor = panel1.BackColor;
            squareBtn.BackColor = panel1.BackColor;
            fillBtn.BackColor = panel1.BackColor;
            eraserBtn.BackColor = panel1.BackColor;
            addTextBtn.BackColor = panel1.BackColor;

            plusBtn.BackColor = panel1.BackColor;
            minusBtn.BackColor = panel1.BackColor;

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
