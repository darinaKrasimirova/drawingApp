using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShapes;

namespace LibraryShapes
{
    public class CoordinateSystem
    {
        public static int coorSystUnit;
        public static Point CSStart;//coordinate system start
        public static void DrawCoordinateSystem(IGraphics g, int unit, Point start, Point end)
        {
            coorSystUnit = unit;
            CSStart = start;
            Color color;
            int a = 0;
            for (int i = start.Y; i <= end.Y; i += unit)
            {
                if (a++ % 5 == 0) color = Color.DarkGray;
                else color = Color.LightGray;
                g.DrawLine(color, 1, new Point(start.X, i), new Point(end.X, i));
            }
            a = 0;
            for (int i = start.X; i <= end.X; i += unit)
            {
                if (a++ % 5 == 0) color = Color.DarkGray;
                else color = Color.LightGray;
                g.DrawLine(color,1, new Point(i, start.Y), new Point(i, end.Y));
            }
        }
    }
}
