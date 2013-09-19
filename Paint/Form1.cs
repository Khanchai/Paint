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
        SolidBrush solidBrush;
        List<Rectangle> rectangles = new List<Rectangle>();
        Rectangle rectang;

        bool paint = false;
        bool start = true;
        bool drawing;

        bool pencil = true;
        bool brush = false;
        bool ellipse = false;
        bool rectangle = false;

        bool shouldpaint = false;
        bool eraser = false;

        int width;
        int height;

        int time = 0;

        Point startPoint;
        Point endPoint;


        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
            solidBrush = new SolidBrush(Color.White);
            width = 20;
            height = 20;
        }

        private Rectangle getRectangle()
        {
            return new Rectangle
                (
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(startPoint.X - endPoint.X),
                    Math.Abs(startPoint.Y - endPoint.Y)
                );
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                start = true;

            }
            paint = true;
            shouldpaint = true;

            endPoint = startPoint = e.Location;
            drawing = true;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            start = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (paint)
            {
                if (time == 0 && !start)
                {
                    startPoint = new Point(e.X, e.Y);
                }
                if (time == 1 && !start)
                {
                    endPoint = startPoint;
                }
                if (start)
                {
                    startPoint = new Point(e.X, e.Y);
                    endPoint = new Point(e.X - 1, e.Y);
                    start = false;
                }

                var graphics = panel1.CreateGraphics();

                if (eraser)
                {
                    graphics.FillRectangle(solidBrush, e.X, e.Y, width, height);
                    graphics.Dispose();
                }

                if (pencil)
                {
                    graphics.DrawLine(pen, startPoint, endPoint);
                    graphics.Dispose();
                }
                //                if (brush)
                //                {
                //                    graphics.FillEllipse(myBrush, e.X, e.Y, 10, 10);
                //                    graphics.Dispose();
                //                }

                if (rectangle)
                {
                    endPoint = e.Location;
                    if (drawing) this.Invalidate();




                    //                rectang = new Rectangle(rectang.Left, rectang.Top, e.X - rectang.Left, e.Y - rectang.Top);
                    //                graphics.DrawRectangle(pen, getRectangle());
                    //                graphics.Dispose();
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rectangles.Count > 0) e.Graphics.DrawRectangles(pen, rectangles.ToArray());
            if (drawing) e.Graphics.DrawRectangle(pen, getRectangle());
        }
        private void Rectangle_Btn(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = true;
            brush = false;
            eraser = false;
        }

        private void Pencil_Btn(object sender, EventArgs e)
        {
            pencil = true;
            rectangle = false;
            brush = false;
            eraser = false;
        }

        private void Brush_Btn(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = true;
            eraser = false;
        }

        private void WidthLine2_Btn(object sender, EventArgs e)
        {
            pen.Width = 2;
            width = 20;
            height = 20;
            
        }

        private void WidthLine3_Btn(object sender, EventArgs e)
        {
            pen.Width = 3;
            width = 30;
            height = 30;
        }

        private void WidthLine4_Btn(object sender, EventArgs e)
        {
            pen.Width = 4;
            width = 40;
            height = 40;
        }

        private void WidthLine5_Btn(object sender, EventArgs e)
        {
            pen.Width = 5;
            width = 50;
            height = 50;
        }

        private void ColorDialog(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = true;
        }
    }
}
