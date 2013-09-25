using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        Graphics graphics;
        GraphicsState initialState;

        Pen pen;
        Pen penEraser;
        SolidBrush solidBrush;

        bool paint = false;
        bool start = true;
        bool drawing;

        bool pencil = true;
        bool brush = false;
        bool ellipse = false;
        bool rectangle = false;
        bool triangle = false;
        bool line = false;

        bool eraser = false;

        int width;
        int height;

        int time = 0;

        Point startPoint;
        Point endPoint;

        //Point p1;
        //Point p2;

        public Form1()
        {
            InitializeComponent();
            Cursor = Cursors.Cross;
            DoubleBuffered = true;
            graphics = CreateGraphics();
            pen = new Pen(Color.Black, 1);
            penEraser = new Pen(Color.White,20);
            solidBrush = new SolidBrush(Color.Black);

            width = 20;
            height = 20;
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                start = true;
            }
            paint = true;
            if (rectangle)
            {
                rect = RectangleTools.Draw(pen, this);
                graphics.DrawRectangle(pen, rect);
            }
            if (ellipse)
            {
                rect = EllipseTools.Draw(pen, this);
                graphics.DrawEllipse(pen, rect); 
            }
            if (triangle)
            {
                LineTools.Drawing = (graphic, pen1, p1, p2) =>
                {
                    //base line
                    var yBase = Math.Max(p1.Y, p2.Y);
                    graphic.DrawLine(pen1, p1.X, yBase, p2.X, yBase);

                    var yApex = Math.Min(p1.Y, p2.Y);
                    var xApex = (p1.X + p2.X)/2;
                    //left side line
                    graphic.DrawLine(pen1, p1.X, yBase, xApex, yApex);
                    //right side line
                    graphic.DrawLine(pen1, p2.X, yBase, xApex, yApex);
                };
                var points = LineTools.Draw(pen, this);
                LineTools.Drawing(graphics, pen, points[0], points[1]);

            }
            if (line)
            {
                LineTools.Drawing = (graphic, pen1, p1, p2) =>
                {
                    graphic.DrawLine(pen1, p2.X, p2.Y, p1.X, p1.Y);
                };
                var points = LineTools.Draw(pen, this);
                //graphics.DrawLine(pen, points[0], points[1]);
                LineTools.Drawing(graphics, pen, points[0], points[1]);
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            start = true;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!paint) return;
            if (time == 0 && !start)
            {
                startPoint = new Point(e.X, e.Y);
//                p1 = new Point(e.X,e.Y);
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

            if (pencil)
            {
                graphics.DrawLine(pen, startPoint, endPoint);
//              graphics.Dispose();
            }

            if (brush)
            {
                graphics.FillEllipse(solidBrush, e.X, e.Y, width, height);
//              graphics.Dispose();
            }

            if (eraser)
            {
                graphics.DrawLine(penEraser, startPoint, endPoint);
//              graphics.Dispose();
            }
            if (line)
            {
                
//                graphics.DrawLine(pen, p1,p2);
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

        private void Pencil_Btn_Click(object sender, EventArgs e)
        {
            pencil = true;
            rectangle = false;
            brush = false;
            eraser = false;
            ellipse = false;
            line = false;
            triangle = false;
            ellipse = false;
            line = false;
        }

        private void Brush_Btn_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = true;
            eraser = false;
            ellipse = false;
            line = false;
            triangle = false;
            ellipse = false;
            line = false;
        }

        private void Eraser_Btn_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = true;
            ellipse = false;
            line = false;
            triangle = false;
            ellipse = false;
            line = false;
        }

        private void LineLv2_Btn_Click(object sender, EventArgs e)
        {
            pen.Width = 2;
            width = 20;
            height = 20;
        }

        private void LineLv3_Btn_Click(object sender, EventArgs e)
        {
            pen.Width = 4;
            width = 23;
            height = 23;
        }

        private void LineLv4_Btn_Click(object sender, EventArgs e)
        {
            pen.Width = 6;
            width = 26;
            height = 26;
        }

        private void Rectangle_Btn_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = true;
            brush = false;
            eraser = false;
            ellipse = false;
            line = false;
            triangle = false;
            ellipse = false;
            line = false;
        }

        private void Triangle_Btn_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = false;
            ellipse = false;
            line = false;
            triangle = true;
            ellipse = false;
            line = false;
        }

        private void Ellipse_Btn_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = false;
            ellipse = false;
            line = false;
            triangle = false;
            ellipse = true;
            line = false;
        }

        private void Line_Btn_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = false;
            ellipse = false;
            line = false;
            triangle = false;
            ellipse = false;
            line = true;
        }

        private void ColorDialog_Btn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ColorDialog_Btn.BackColor = colorDialog1.Color;
            pen.Color = colorDialog1.Color;
            solidBrush.Color = colorDialog1.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
