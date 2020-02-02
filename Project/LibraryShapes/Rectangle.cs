 using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes
{
    public class Rectangle:Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(Point start, int width, int height)
        {
            Position = start;
            Width = width;
            Height = height;
        }
        private void SetCharacteristics()
        {
            FrameStart = new Point(Position.X *CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.X, Position.Y * CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.Y);
            FrameWidth = Width * CoordinateSystem.coorSystUnit;
            FrameHeight = Height * CoordinateSystem.coorSystUnit;
        }
        public override void Paint(IGraphics g, Color clr, int penWidth)
        {
            SetCharacteristics();
            g.DrawRectangle(clr, penWidth,FrameStart.X,FrameStart.Y,FrameWidth, FrameHeight);
            SetShapeProperties(clr, penWidth);
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override void Move(Point p)
        {
            Position = p;
            SetCharacteristics();
        }
        public override void Resize(int width, int height)
        {
            Width = width;
            Height = height;
            SetCharacteristics();
        }
        public override void FillIn(IGraphics g, Color fillingColor)
        {
            g.FillRectangle(fillingColor, FrameStart.X, FrameStart.Y, FrameWidth, FrameHeight);
            base.FillIn(g, fillingColor);
        }
    }
}

