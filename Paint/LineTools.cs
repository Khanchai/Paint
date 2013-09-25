using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public class LineTools
    {
        private static Form mMask;
        private static Point mPos;
        private static Pen sPen;

        public static Point[] Draw(Pen pen, Form parent)
        {
            sPen = pen;
            // Record the start point
            mPos = parent.PointToClient(Control.MousePosition);
            // Create a transparent form on top of  the parent form
            mMask = new Form();
            mMask.FormBorderStyle = FormBorderStyle.None;
            mMask.BackColor = Color.Magenta;
            mMask.TransparencyKey = mMask.BackColor;

            mMask.ShowInTaskbar = false;
            mMask.StartPosition = FormStartPosition.Manual;
            mMask.Size = parent.ClientSize;
            mMask.Location = parent.PointToScreen(Point.Empty);
            mMask.MouseMove += MouseMove;
            mMask.MouseUp += MouseUp;
            mMask.Paint += PaintRectangle;
            mMask.Load += DoCapture;
            // Display the overlay
            mMask.ShowDialog(parent);
            // Clean-up and calculate return value
            mMask.Dispose();
            mMask = null;
            var pos = parent.PointToClient(Control.MousePosition);

            return new[] {mPos, pos};
        }

        private static void DoCapture(object sender, EventArgs e)
        {
            // Grab the mouse
            mMask.Capture = true;
        }
        private static void MouseMove(object sender, MouseEventArgs e)
        {
            // Repaint the rectangle
            mMask.Invalidate();
        }
        private static void MouseUp(object sender, MouseEventArgs e)
        {
            // Done, close mask
            mMask.Close();
        }

        public static Action<Graphics, Pen, Point, Point> Drawing { get; set; } 

        private static void PaintRectangle(object sender, PaintEventArgs e)
        {
            // Draw the current rectangle
            Point pos = mMask.PointToClient(Control.MousePosition);
            Drawing(e.Graphics, sPen, mPos, pos);

        }
    }
}
