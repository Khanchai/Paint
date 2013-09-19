using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    [Serializable]
    public class FillStyle
    {
        private String name;
        private Image image;
        private HatchStyle style;

        public FillStyle(String name, Image image, HatchStyle style)
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

        public HatchStyle Style
        {
            get { return style; }
        }
    }
}
