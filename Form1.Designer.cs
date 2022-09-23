
namespace Patterns_Drawer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.redoBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.eraserBtn = new System.Windows.Forms.Button();
            this.pointerBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.colorBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.minusBtn);
            this.panel1.Controls.Add(this.plusBtn);
            this.panel1.Controls.Add(this.redoBtn);
            this.panel1.Controls.Add(this.undoBtn);
            this.panel1.Controls.Add(this.lineBtn);
            this.panel1.Controls.Add(this.eraserBtn);
            this.panel1.Controls.Add(this.pointerBtn);
            this.panel1.Controls.Add(this.fillBtn);
            this.panel1.Controls.Add(this.squareBtn);
            this.panel1.Controls.Add(this.circleBtn);
            this.panel1.Controls.Add(this.colorBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 48);
            this.panel1.TabIndex = 0;
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.Transparent;
            this.minusBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.minus;
            this.minusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minusBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.ForeColor = System.Drawing.Color.Black;
            this.minusBtn.Location = new System.Drawing.Point(860, 3);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(40, 40);
            this.minusBtn.TabIndex = 13;
            this.minusBtn.UseVisualStyleBackColor = false;
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.Transparent;
            this.plusBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.plus;
            this.plusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plusBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.ForeColor = System.Drawing.Color.Black;
            this.plusBtn.Location = new System.Drawing.Point(814, 3);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(40, 40);
            this.plusBtn.TabIndex = 12;
            this.plusBtn.UseVisualStyleBackColor = false;
            // 
            // redoBtn
            // 
            this.redoBtn.BackColor = System.Drawing.Color.Transparent;
            this.redoBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.redo;
            this.redoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.redoBtn.FlatAppearance.BorderSize = 0;
            this.redoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoBtn.ForeColor = System.Drawing.Color.Black;
            this.redoBtn.Location = new System.Drawing.Point(1281, 3);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(40, 40);
            this.redoBtn.TabIndex = 11;
            this.redoBtn.UseVisualStyleBackColor = false;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.BackColor = System.Drawing.Color.Transparent;
            this.undoBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.undo;
            this.undoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.undoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.undoBtn.FlatAppearance.BorderSize = 0;
            this.undoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoBtn.ForeColor = System.Drawing.Color.Black;
            this.undoBtn.Location = new System.Drawing.Point(1235, 3);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(40, 40);
            this.undoBtn.TabIndex = 10;
            this.undoBtn.UseVisualStyleBackColor = false;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.Color.Transparent;
            this.lineBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.line;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lineBtn.FlatAppearance.BorderSize = 0;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.ForeColor = System.Drawing.Color.Black;
            this.lineBtn.Location = new System.Drawing.Point(409, 3);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(40, 40);
            this.lineBtn.TabIndex = 9;
            this.lineBtn.Tag = "line";
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // eraserBtn
            // 
            this.eraserBtn.BackColor = System.Drawing.Color.Transparent;
            this.eraserBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.rubber;
            this.eraserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eraserBtn.FlatAppearance.BorderSize = 0;
            this.eraserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserBtn.ForeColor = System.Drawing.Color.Black;
            this.eraserBtn.Location = new System.Drawing.Point(655, 3);
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(40, 40);
            this.eraserBtn.TabIndex = 8;
            this.eraserBtn.Tag = "erase";
            this.eraserBtn.UseVisualStyleBackColor = false;
            this.eraserBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // pointerBtn
            // 
            this.pointerBtn.BackColor = System.Drawing.Color.Transparent;
            this.pointerBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.pointer;
            this.pointerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pointerBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pointerBtn.FlatAppearance.BorderSize = 0;
            this.pointerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointerBtn.ForeColor = System.Drawing.Color.Black;
            this.pointerBtn.Location = new System.Drawing.Point(281, 3);
            this.pointerBtn.Name = "pointerBtn";
            this.pointerBtn.Size = new System.Drawing.Size(40, 40);
            this.pointerBtn.TabIndex = 7;
            this.pointerBtn.Tag = "select";
            this.pointerBtn.UseVisualStyleBackColor = false;
            this.pointerBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.BackColor = System.Drawing.Color.Transparent;
            this.fillBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.fill;
            this.fillBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fillBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fillBtn.FlatAppearance.BorderSize = 0;
            this.fillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillBtn.ForeColor = System.Drawing.Color.Black;
            this.fillBtn.Location = new System.Drawing.Point(591, 3);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(40, 40);
            this.fillBtn.TabIndex = 6;
            this.fillBtn.Tag = "fill";
            this.fillBtn.UseVisualStyleBackColor = false;
            this.fillBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.BackColor = System.Drawing.Color.Transparent;
            this.squareBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.square;
            this.squareBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.squareBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.squareBtn.FlatAppearance.BorderSize = 0;
            this.squareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareBtn.ForeColor = System.Drawing.Color.Black;
            this.squareBtn.Location = new System.Drawing.Point(527, 3);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(40, 40);
            this.squareBtn.TabIndex = 5;
            this.squareBtn.Tag = "rect";
            this.squareBtn.UseVisualStyleBackColor = false;
            this.squareBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // circleBtn
            // 
            this.circleBtn.BackColor = System.Drawing.Color.Transparent;
            this.circleBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.circle;
            this.circleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.circleBtn.FlatAppearance.BorderSize = 0;
            this.circleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleBtn.ForeColor = System.Drawing.Color.Black;
            this.circleBtn.Location = new System.Drawing.Point(473, 3);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(40, 40);
            this.circleBtn.TabIndex = 4;
            this.circleBtn.Tag = "circle";
            this.circleBtn.UseVisualStyleBackColor = false;
            this.circleBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.Black;
            this.colorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.colorBtn.FlatAppearance.BorderSize = 3;
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBtn.ForeColor = System.Drawing.Color.Black;
            this.colorBtn.Location = new System.Drawing.Point(176, 6);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(35, 35);
            this.colorBtn.TabIndex = 2;
            this.colorBtn.UseVisualStyleBackColor = false;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.clear;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(67, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(40, 40);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackgroundImage = global::Patterns_Drawer.Properties.Resources.save;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(3, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(40, 40);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1333, 659);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Ы";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button circleBtn;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.Button pointerBtn;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button eraserBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button redoBtn;
    }
}

