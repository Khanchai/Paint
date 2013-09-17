using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Pen pen;
        SolidBrush myBrush;
        Rectangle rectang;


        bool paint = false;
        bool start = true;
        bool start1 = true;

        bool pencil = true;
        bool brush = false;
        bool ellipse = false;
        bool rectangle = false;
        

        bool eraser = false;

        int time = 0;
        
        Point point1;
        Point point2;
        

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                start = true;

            }
            paint = true;
            rectang = new Rectangle(e.X, e.Y, 0, 0);
            Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            start = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!paint) return;
            if (time == 0 && !start)
            {
                point1 = new Point(e.X,e.Y);
            }
            if(time == 1 && !start)
            {
                point2 = point1;
            }
            if (start)
            {
                point1 = new Point(e.X,e.Y);
                point2 = new Point(e.X-1,e.Y);
                start = false;
            }
           
            var graphics = panel1.CreateGraphics();
            var formGraphics = panel1.CreateGraphics();
            myBrush = new SolidBrush(Color.Red);

            if (pencil)
            {
                graphics.DrawLine(pen, point1, point2);
                graphics.Dispose();
            }
            if (brush)
            {
                graphics.FillEllipse(myBrush, e.X, e.Y, 10, 10);
                graphics.Dispose();
            }

            if (rectangle)
            {

                rectang = new Rectangle(rectang.Left, rectang.Top, e.X - rectang.Left, e.Y - rectang.Top);
//                graphics.FillRectangle(brush,rectang);
                graphics.DrawRectangle(pen, rectang);
                graphics.Dispose();
            }

            if (!start) { time++; }
            if (time > 1) { time = 0; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Rectangle_Btn(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = true;
            brush = false;

        }

        private void Pencil_Btn(object sender, EventArgs e)
        {
            pencil = true;
            rectangle = false;
            brush = false;
        }

        private void Brush_Btn(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = true;
        }

        private void WidthLine2_Btn(object sender, EventArgs e)
        {
            pen.Width = 2;
        }

        private void WidthLine3_Btn(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void WidthLine4_Btn(object sender, EventArgs e)
        {
            pen.Width = 4;
        }

        private void WidthLine5_Btn(object sender, EventArgs e)
        {
            pen.Width = 5;
        }

        private void ColorDialog (object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }




    }
}
