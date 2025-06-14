using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulas.clases
{
        internal class circunferenceBresenham
        {

            public static void DrawCircle(int xc, int yc, int r, Action<int, int> drawPixel)
            {
                int x = 0;
                int y = r;
                int d = 3 - 2 * r;

                while (y >= x)
                {
                    drawPixel(xc + x, yc + y);
                    drawPixel(xc - x, yc + y);
                    drawPixel(xc + x, yc - y);
                    drawPixel(xc - x, yc - y);
                    drawPixel(xc + y, yc + x);
                    drawPixel(xc - y, yc + x);
                    drawPixel(xc + y, yc - x);
                    drawPixel(xc - y, yc - x);

                    x++;

                    if (d > 0)
                    {
                        y--;
                        d = d + 4 * (x - y) + 10;
                    }
                    else
                    {
                        d = d + 4 * x + 6;
                    }
                }
            }
        }
}
