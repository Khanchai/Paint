using System;
using System.Drawing;

namespace Paint
{
    [Serializable]
    public class LineSize
    {
        private String name;
        private Image image;
        private int size;

        public LineSize(String name, Image image, int size)
        {
            this.name = name;
            this.image = image;
            this.size = size;
        }

        public String Name
        {
            get { return name; }
        }

        public Image Image
        {
            get { return image; }
        }

        public int Size
        {
            get { return size; }
        }
    }
}
