namespace paintApp
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Open = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.fn_eraser = new System.Windows.Forms.Button();
            this.fn_line = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_color = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.AutoSize = true;
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(958, 581);
            this.pic.TabIndex = 0;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 581);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.color_picker);
            this.panel3.Controls.Add(this.pic_color);
            this.panel3.Controls.Add(this.Open);
            this.panel3.Controls.Add(this.btn_clr);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.fn_eraser);
            this.panel3.Controls.Add(this.fn_line);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Location = new System.Drawing.Point(11, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 562);
            this.panel3.TabIndex = 0;
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.Black;
            this.Open.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Open.Location = new System.Drawing.Point(18, 441);
            this.Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(74, 22);
            this.Open.TabIndex = 10;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.Color.Black;
            this.btn_clr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clr.Location = new System.Drawing.Point(16, 493);
            this.btn_clr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(74, 22);
            this.btn_clr.TabIndex = 9;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(16, 467);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 22);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.Black;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::paintApp.Properties.Resources.circle;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(16, 230);
            this.btn_ellipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(74, 47);
            this.btn_ellipse.TabIndex = 6;
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Black;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::paintApp.Properties.Resources.color;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_color.Location = new System.Drawing.Point(16, 80);
            this.btn_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(74, 43);
            this.btn_color.TabIndex = 5;
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseCompatibleTextRendering = true;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.Black;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::paintApp.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(16, 174);
            this.btn_rect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(74, 52);
            this.btn_rect.TabIndex = 7;
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // fn_eraser
            // 
            this.fn_eraser.BackColor = System.Drawing.Color.Black;
            this.fn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fn_eraser.ForeColor = System.Drawing.Color.White;
            this.fn_eraser.Image = global::paintApp.Properties.Resources.eraser;
            this.fn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fn_eraser.Location = new System.Drawing.Point(18, 44);
            this.fn_eraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fn_eraser.Name = "fn_eraser";
            this.fn_eraser.Size = new System.Drawing.Size(73, 32);
            this.fn_eraser.TabIndex = 4;
            this.fn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fn_eraser.UseVisualStyleBackColor = false;
            this.fn_eraser.Click += new System.EventHandler(this.fn_eraser_Click);
            // 
            // fn_line
            // 
            this.fn_line.BackColor = System.Drawing.Color.Black;
            this.fn_line.ForeColor = System.Drawing.Color.White;
            this.fn_line.Image = global::paintApp.Properties.Resources.line;
            this.fn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fn_line.Location = new System.Drawing.Point(18, 127);
            this.fn_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fn_line.Name = "fn_line";
            this.fn_line.Size = new System.Drawing.Size(74, 43);
            this.fn_line.TabIndex = 2;
            this.fn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fn_line.UseVisualStyleBackColor = false;
            this.fn_line.Click += new System.EventHandler(this.fn_line_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.Black;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::paintApp.Properties.Resources.pencil1;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pencil.Location = new System.Drawing.Point(17, 11);
            this.btn_pencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(80, 29);
            this.btn_pencil.TabIndex = 0;
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            this.btn_pencil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.btn_pencil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.btn_pencil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(901, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 581);
            this.panel2.TabIndex = 2;
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic_color.Location = new System.Drawing.Point(17, 294);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(75, 23);
            this.pic_color.TabIndex = 11;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::paintApp.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(0, 323);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(112, 113);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 12;
            this.color_picker.TabStop = false;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button fn_eraser;
        private System.Windows.Forms.Button fn_line;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox color_picker;
    }
}

