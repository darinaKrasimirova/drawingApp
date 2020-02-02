 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LibraryShapes
{
    public interface IGraphics
    {
        void DrawLine(Color color,int penWidth, Point start, Point end);
        void DrawRectangle(Color color, int penWidth, int pointStartX, int pointStartY, int width, int height);
        void DrawEllipse(Color color, int penWidth, int pointStartX,int pointStartY,int frameWidth,int frameHeight);
        void DrawPolygon(Color color, int penWidth, Point[] points);
        void FillRectangle(Color fillingColor, int pointStartX, int pointStartY, int width, int height);
        void FillEllipse(Color fillingColor, int pointStartX, int pointStartY, int frameWidth, int frameHeight);
        void FillPolygon(Color fillingColor,Point[] points);
    }
}
