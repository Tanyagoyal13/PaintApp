using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace paintApp
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();

            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.BackgroundImage = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 3);
        Pen eraser = new Pen(Color.White, 10);

        int index;
        int x, y, sY, sX, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;


        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
            
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {

                if (index == 1)
                {
                    px = e.Location; 
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
                pic.Invalidate();
                
            }


            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.BackgroundImage = bm;
            pic.Refresh();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var dgb = new SaveFileDialog();
            dgb.Filter = "Image(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dgb.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(dgb.FileName, ImageFormat.Bmp);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(open.FileName);
                g = Graphics.FromImage(bm);
                pic.BackgroundImage = bm;
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color=cd.Color;   
                
        }
        
         static Point set_point(PictureBox pb,Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor=((Bitmap)color_picker.Image).GetPixel(point.X,point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
                      
            
        }
        private void validate(Bitmap bm, Stack<Point>sp,int x, int y, Color old_color,Color new_color)
        {
            Color cx= bm.GetPixel(x,y);
            if(cx==old_color)
            {
                sp.Push(new Point(x,y));
                bm.SetPixel(x, y,new_color);


            }
        }
        public void Fill(Bitmap bm,int x , int y , Color new_clr)
        {
            Color old_color=bm.GetPixel(x,y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x,y));
            bm.SetPixel(x , y,new_clr);
            if(old_color==new_clr)return;
            while(pixel.Count > 0) 
            { 
                Point pt = (Point)pixel.Pop();
                if(pt.X>0 && pt.Y>0 && pt.X<bm.Height-1 && pt.Y<bm.Height-1)
                {
                    validate(bm,pixel,pt.X-1,pt.Y,old_color,new_clr);
                    validate(bm, pixel, pt.X, pt.Y-1, old_color, new_clr);
                    validate(bm, pixel, pt.X+1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y+1, old_color, new_clr);

                }

            }
        }

        private void color_picker_Click(object sender, EventArgs e)
        {

        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if(index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY); 
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x,y);  
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void fn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void fn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        

    }
}
