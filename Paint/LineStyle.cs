using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    [Serializable]
    public class LineStyle
    {
        private String name;
        private Image image;
        private DashStyle style;

        public LineStyle(String name, Image image, DashStyle style)
        {
            this.name = name;
            this.image = image;
            this.style = style;
        }

        public String Name
        {
            get { return name; }
        }

        public Image Image
        {
            get { return image; }
        }

        public DashStyle Style
        {
            get { return style; }
        }

    }
}
