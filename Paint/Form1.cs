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

        Rectangle rectangle;

        bool paint = false;
        bool start = true;
        bool line = true;
        bool ellipse = false;
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
                point2 = new Point(e.X,e.Y);
                start = false;
            }

            Graphics graphics = panel1.CreateGraphics();

            if (line)
            {
                graphics.DrawLine(pen, point1, point2);
                graphics.Dispose();
            }

            if (!start)
            {
                time++;
            }
            if (time > 1)
            {
                time = 0;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool line = true;
        }

        private void WidthLine2(object sender, EventArgs e)
        {
            pen.Width = 2;
        }

        private void WidthLine3(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void WidthLine4(object sender, EventArgs e)
        {
            pen.Width = 4;
        }

        private void WidthLine5(object sender, EventArgs e)
        {
            pen.Width = 5;
        }

        private void ColorDialog (object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
        }

        private void Rectangle(object sender, EventArgs e)
        {
              
        }
    }
}
