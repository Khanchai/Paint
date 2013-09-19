using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class PencilTools 
    {
        Point startPoint { get; set; }
        Point endPoint { get; set; }

        public void Draw(Point p1, Point p2)
        {
            startPoint = p1;
            endPoint = p2;
            
        }


    }
    
}
