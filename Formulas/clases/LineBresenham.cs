using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Formulas.clases
{
    internal class LineBresenham
    {
        private Point pointInit;
        private Point pointEnd;

        public LineBresenham(Point pointInit, Point pointEnd)
        {
            this.pointInit = pointInit;
            this.pointEnd = pointEnd;
        }

        public Point[] getBresenhamPoints()
        {
            var points = new List<Point>();

            int x0 = pointInit.X;
            int y0 = pointInit.Y;
            int x1 = pointEnd.X;
            int y1 = pointEnd.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);

            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            int err = dx - dy;

            while (true)
            {
                points.Add(new Point(x0, y0));
                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * err;
                if (e2 >= -dy)
                {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }

            return points.ToArray();
        }
    }
}
