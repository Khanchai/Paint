using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    abstract class DrawTools
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public PaintContext context { get; set; }

        public DrawTools(Point pointStart,Point pointEnd)
        {
            startPoint = pointStart;
            endPoint = pointEnd;
        }
    }
}
