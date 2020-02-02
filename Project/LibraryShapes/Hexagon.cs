using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes
{
    public class Hexagon:Shape
    {
        public int Side { get; set; }
        private Point[] points = new Point[6];
        private double height;
        public Hexagon(Point center, int side)
        {
            Position = center;
            Side = side;//side=radius
        }
        private void SetCharacteristics()
        {
            height = Math.Sqrt(3) / 2 * Side;
            FrameStart = new Point((int)(Position.X* CoordinateSystem.coorSystUnit +
                CoordinateSystem.CSStart.X - Side* CoordinateSystem.coorSystUnit),
                (int)(Position.Y* CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.Y -
                height* CoordinateSystem.coorSystUnit));
            FrameWidth = 2 * Side* CoordinateSystem.coorSystUnit;
            FrameHeight = 2 * (int)(height* CoordinateSystem.coorSystUnit);
            points[0] = new Point((int)(FrameStart.X + Side* CoordinateSystem.coorSystUnit / 2), FrameStart.Y);
            points[1] = new Point((int)(FrameStart.X + 3 * Side* CoordinateSystem.coorSystUnit / 2), FrameStart.Y);
            points[2] = new Point((int)(FrameStart.X + 2 * Side* CoordinateSystem.coorSystUnit), (int)(FrameStart.Y + height* CoordinateSystem.coorSystUnit));
            points[3] = new Point(points[1].X, (int)(points[1].Y + 2 * height* CoordinateSystem.coorSystUnit));
            points[4] = new Point(points[0].X, points[3].Y);
            points[5] = new Point(FrameStart.X, points[2].Y);
        }
        public override void Paint(IGraphics g, Color clr, int penWidth)
        {
            SetCharacteristics();
            g.DrawPolygon(clr, penWidth, points);
            SetShapeProperties(clr, penWidth);
        }
        public override double GetArea()
        {
            return 3 * Side * height;
        }
        public override void Move(Point p)
        {
            Position = p;
            SetCharacteristics();
        }
        public override void Resize(int side, int a)   //'a' is a nothing meaning variable so that the 
        {                                                 //virtual method can be overriden
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
