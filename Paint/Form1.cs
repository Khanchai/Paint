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
        Pen pen;
        Graphics graphics;
        SolidBrush solidBrushEraser;
        SolidBrush solidBrush;
        Rectangle rectang;
        GraphicsState initialState;

        DashStyle dashStyle;
        HatchStyle hatchStyle;

        bool paint = false;
        bool start = true;
        bool drawing;

        bool pencil = true;
        bool brush = false;
        bool ellipse = false;
        bool rectangle = false;
        bool line = false;

        bool eraser = false;

        int width;
        int height;

        int time = 0;

        Point startPoint;
        Point endPoint;



        Point startPos;      
        Point currentPos;    

        public Form1()
        {
            InitializeComponent();
            Cursor = Cursors.Cross;
            DoubleBuffered = true;
           
            pen = new Pen(Color.Black, 1);
            solidBrushEraser = new SolidBrush(Color.White);
            solidBrush = new SolidBrush(Color.Black);
           
            width = 20;
            height = 20;
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
                    startPoint = new Point(e.X-2, e.Y-2);
                    endPoint = new Point(e.X - 2, e.Y-2);
                    start = false;
                }

                graphics = panel1.CreateGraphics();

                if (eraser)
                {
                    graphics.FillRectangle(solidBrushEraser, e.X, e.Y, width, height);
                    graphics.Dispose();
                }

                if (pencil)
                {
                    graphics.DrawLine(pen, startPoint, endPoint);
                    graphics.Dispose();
                }
                if (brush)
                {
                    graphics.FillEllipse(solidBrush, e.X, e.Y, width, height);
                    graphics.Dispose();
                }

                if (rectangle)
                {
//                     rectang = new Rectangle(startPos.X, startPos.Y, currentPos.X - startPos.X, currentPos.Y - startPos.Y);
//                            Math.Min(startPos.X, currentPos.X),
//                            Math.Min(startPos.Y, currentPos.Y),
//                            Math.Abs(startPos.X - currentPos.X),
//                            Math.Abs(startPos.Y - currentPos.Y));
//                     int xpos = (currentPos.X - startPos.X < startPos.X) ? currentPos.X : startPos.X;
//                     int ypos = (currentPos.Y - startPos.Y < startPos.Y) ? currentPos.Y : startPos.Y;
//                     int width = Math.Abs(currentPos.X - startPos.X);
//                     int height = Math.Abs(currentPos.Y - startPos.Y);
//                   
//                    if (startPos.X < currentPos.X)
//                    {
//                        drawX = startPos.X;
//                        width = currentPos.X - startPos.X;
//                    }
//                    else
//                    {
//                        drawX = currentPos.X;
//                        width = startPos.X - currentPos.X;
//                    }
//
//                    if (startPos.Y < currentPos.Y)
//                    {
//                        drawY = startPos.Y;
//                        height = currentPos.Y - startPos.Y;
//                    }
//                    else
//                    {
//                        drawY = currentPos.Y;
//                        height = startPos.Y - currentPos.Y;
//                    }
//                    rectang = new Rectangle(drawX, drawY, width, height);

//                     graphics.DrawRectangle(Pens.Blue, new Rectangle(xpos, ypos, width, height));

                    rectang = RectangleTools.Draw(pen, this);
                    graphics.DrawRectangle(pen, rectang);


                  
                }

                if (ellipse)
                {
                    rectang = new Rectangle(e.X, e.Y, 90, 30);
                    graphics.DrawEllipse(pen, rectang);
                }

                if (line)
                {

                    graphics.DrawLine(pen,startPoint,endPoint);
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

        }
        private void Rectangle_Btn(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = true;
            brush = false;
            eraser = false;
            ellipse = false;
            line = false;
        }

        private void Pencil_Btn(object sender, EventArgs e)
        {
            pencil = true;
            rectangle = false;
            brush = false;
            eraser = false;
            ellipse = false;
            line = false;
        }

        private void Brush_Btn(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = true;
            eraser = false;
            ellipse = false;
            line = false;
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
            solidBrush.Color = colorDialog1.Color;
        }

        private void Eraser_Btn(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = true;
            ellipse = false;
            line = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = false;
            ellipse = true;
            line = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pencil = false;
            rectangle = false;
            brush = false;
            eraser = false;
            ellipse = false;
            line = true;
        }
    }
}
