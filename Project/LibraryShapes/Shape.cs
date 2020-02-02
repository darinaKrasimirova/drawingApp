using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes
{
    public abstract class Shape
    {
        public int SerialNum;
        public bool filled = false;
        public Point Position{ get; set; }
        protected Point FrameStart { get; set; }
        protected int FrameWidth { get; set; }
        protected int FrameHeight { get; set; }
        public Color ShapeContourColor { get; set; }
        public int ShapeContourWidth { get; set; }
        public Color FillingColor { get; set; }

        public abstract void Paint(IGraphics g, Color clr, int penWidth);
        protected void SetShapeProperties(Color clr, int penWidth)
        {
            ShapeContourColor = clr;
            ShapeContourWidth = penWidth;
        }
        public abstract double GetArea();
        public virtual void Move(Point p)
        {
            FrameStart = p;
        }
        public abstract void Resize(int characteristic1, int characteristic2 = 0);
        public virtual void FillIn(IGraphics g, Color fillingColor)
        {
            FillingColor = fillingColor;
        }
        public bool Contains(Point p)
        {
            if (p.X >= FrameStart.X && p.X <= FrameStart.X + FrameWidth)
                if (p.Y >= FrameStart.Y && p.Y <= FrameStart.Y + FrameHeight) return true;
            return false;
        }
        public void DrawFrame(IGraphics g)
        {
            g.DrawRectangle(Color.OrangeRed, 1, FrameStart.X,FrameStart.Y, FrameWidth, FrameHeight);
        }
    }
}
