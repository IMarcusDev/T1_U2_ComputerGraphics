using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulas.clases
{
    internal class FillAlgorithm
    {
        public static Point[] Recursive_Flood_Fill(Bitmap canvas, int x, int y, Color fillColor, int maxDepth = 10000)
        {
            Color targetColor = canvas.GetPixel(x, y);
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return new Point[0];

            HashSet<Point> visited = new HashSet<Point>();
            List<Point> result = new List<Point>();

            RecursiveFill(canvas, x, y, targetColor, fillColor, visited, result, 0, maxDepth);

            return result.ToArray();
        }

        private static void RecursiveFill(Bitmap canvas, int x, int y, Color targetColor, Color fillColor, HashSet<Point> visited, List<Point> result, int depth, int maxDepth)
        {
            if (depth > maxDepth)
                return;
            if (x < 0 || y < 0 || x >= canvas.Width || y >= canvas.Height)
                return;

            Point p = new Point(x, y);
            if (visited.Contains(p))
                return;

            if (canvas.GetPixel(x, y).ToArgb() != targetColor.ToArgb())
                return;

            canvas.SetPixel(x, y, fillColor);
            result.Add(p);
            visited.Add(p);

            RecursiveFill(canvas, x, y + 1, targetColor, fillColor, visited, result, depth + 1, maxDepth);
            RecursiveFill(canvas, x + 1, y, targetColor, fillColor, visited, result, depth + 1, maxDepth);
            RecursiveFill(canvas, x, y - 1, targetColor, fillColor, visited, result, depth + 1, maxDepth);
            RecursiveFill(canvas, x - 1, y, targetColor, fillColor, visited, result, depth + 1, maxDepth);
        }
    }
}
