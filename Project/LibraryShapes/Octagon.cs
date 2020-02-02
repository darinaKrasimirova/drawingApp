using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes
{
    public class Octagon:Shape
    {
        public int Side { get; set; }
        private Point[] points = new Point[8];
        public Octagon(Point center, int side)
        {
            Position = center;
            Side = side;
        }
        private void SetCharacteristics()
        {
            int framePart = (int)(Side / Math.Sqrt(2))*CoordinateSystem.coorSystUnit;     
            FrameStart = new Point(Position.X * CoordinateSystem.coorSystUnit + 
                CoordinateSystem.CSStart.X-Side* CoordinateSystem.coorSystUnit / 2 - framePart,
                Position.Y* CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.Y -
                Side* CoordinateSystem.coorSystUnit / 2 - framePart);
            FrameWidth = Side* CoordinateSystem.coorSystUnit + 2 * framePart;
            FrameHeight = FrameWidth;
            points[0] = new Point(FrameStart.X + framePart, FrameStart.Y);
            points[1] = new Point(points[0].X + Side* CoordinateSystem.coorSystUnit, FrameStart.Y);
            points[2] = new Point(FrameStart.X + FrameWidth, FrameStart.Y + framePart);
            points[3] = new Point(FrameStart.X + FrameWidth, points[2].Y + Side* CoordinateSystem.coorSystUnit);
            points[4] = new Point(points[1].X, FrameStart.Y + FrameHeight);
            points[5] = new Point(points[0].X, points[4].Y);
            points[6] = new Point(FrameStart.X, points[3].Y);
            points[7] = new Point(points[6].X, points[2].Y);
        }
        public override void Paint(IGraphics g, Color clr, int penWidth)
        {
            SetCharacteristics();
            g.DrawPolygon(clr,penWidth, points);
            SetShapeProperties(clr, penWidth);
        }
        public override double GetArea()
        {
            return (2 + 2 * Math.Sqrt(2)) * Math.Pow(Side, 2);
        }
        public override void Move(Point p)
        {
            Position = p;
            SetCharacteristics();
        }
        public override void Resize(int side, int a)
        {
            Side = side;
            SetCharacteristics();
        }
        public override void FillIn(IGraphics g, Color fillingColor)
        {
            base.FillIn(g, fillingColor);
            g.FillPolygon(fillingColor, points);
        }

    }
}
