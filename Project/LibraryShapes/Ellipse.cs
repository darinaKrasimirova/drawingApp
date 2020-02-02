using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShapes
{
    public class Ellipse:Shape
    {
        public int RadiusX { get; set; }
        public int RadiusY { get; set; }
        public Ellipse(Point centre, int radiusX , int radiusY)
        {
            Position = centre;
            RadiusX = radiusX;
            RadiusY = radiusY;
        }
        private void SetCharacteristics()
        {
            FrameStart = new Point(Position.X* CoordinateSystem.coorSystUnit + CoordinateSystem.CSStart.X 
                - RadiusX* CoordinateSystem.coorSystUnit, Position.Y* CoordinateSystem.coorSystUnit +
                CoordinateSystem.CSStart.Y - RadiusY* CoordinateSystem.coorSystUnit);
            FrameWidth = RadiusX* CoordinateSystem.coorSystUnit * 2;
            FrameHeight = RadiusY * CoordinateSystem.coorSystUnit * 2;
        }
        public override void Paint(IGraphics g, Color clr, int penWidth=2)
        {
            SetCharacteristics();
            g.DrawEllipse(clr, penWidth,FrameStart.X, FrameStart.Y,FrameWidth,FrameHeight);
            SetShapeProperties(clr, penWidth);
        }
        public override double GetArea()
        {
            return Math.PI * RadiusX * RadiusY;
        }
        public override void Move(Point p)
        {
            Position = p;
            SetCharacteristics();
        }
        public override void Resize(int radiusX, int raduisY)
        {
            RadiusX = radiusX;
            RadiusY = raduisY;
            SetCharacteristics();
        }
        public override void FillIn(IGraphics g, Color fillingColor)
        {
            g.FillEllipse(fillingColor, FrameStart.X, FrameStart.Y, FrameWidth, FrameHeight);
            base.FillIn(g, fillingColor);
        }
    }

}
