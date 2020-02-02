using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes
{
    public class Triangle:Shape
    {
        public int BaseLine { get; set; }
        public int Height { get; set; }
        private Point[] points = new Point[3];

        public Triangle(Point baseStart,int baseLine, int height)
        {
            BaseLine = baseLine;
            Height = height;
            Position = baseStart;
        }
        private void SetCharacteristics()
        {
            points[0] = new Point(Position.X * CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.X, Position.Y * CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.Y);
            points[1] = new Point(Position.X* CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.X + BaseLine* CoordinateSystem.coorSystUnit, Position.Y* CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.Y);
            points[2] = new Point(Position.X * CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.X + BaseLine* CoordinateSystem.coorSystUnit / 2, Position.Y * CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.Y - Height* CoordinateSystem.coorSystUnit);
            FrameStart = new Point(Position.X * CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.X, Position.Y * CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.Y - Height* CoordinateSystem.coorSystUnit);
            FrameHeight = Height* CoordinateSystem.coorSystUnit;
            FrameWidth = BaseLine* CoordinateSystem.coorSystUnit;
        }
        public override void Paint(IGraphics g, Color clr, int penWidth = 2)
        {
            SetCharacteristics();
            g.DrawPolygon(clr,penWidth, points);
            SetShapeProperties(clr,penWidth);
        }
        public override double GetArea()
        {
            return (double)BaseLine * Height / 2;
        }
        public override void Move(Point p)
        {
            Position= p;
            SetCharacteristics();
        }
        public override void Resize(int baseLine, int height)
        {
            BaseLine = baseLine;
            Height = height;
            SetCharacteristics();
        }
        public override void FillIn(IGraphics g, Color fillingColor)
        {
            g.FillPolygon(fillingColor, points);
            base.FillIn(g, fillingColor);
        }
    }
}
