using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    [Serializable]
    public class PaintContext
    {
        public Color fillColor { get; set; }
        public FillStyle fillStyle { get; set; }
        public Color penColor { get; set; }
        public LineSize penSize { get; set; }
        public LineStyle penStyle { get; set; }

        public Pen createPen()
        {
            Pen pen = new Pen(penColor, penSize.Size);
            pen.DashStyle = penStyle.Style;
            return pen;
        }

        public Brush createBrush()
        {
            return new HatchBrush(fillStyle.Style, fillColor, Color.White);
        }

        public static PaintContext Copy(PaintContext ctx)
        {
            return (PaintContext)ctx.MemberwiseClone();
        }
    }
}
