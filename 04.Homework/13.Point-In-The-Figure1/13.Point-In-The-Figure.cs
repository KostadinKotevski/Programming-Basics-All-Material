using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;

            int x2 = 3 * h;
            int y2 = h;

            int x3 = h;
            int y3 = h;

            int x4 = 2 * h;
            int y4 = 4 * h;

            bool isInsideFirstRect = (x > x1 && x < x2 && y > y1 && y < y2);
            bool isInsideSecondRect = (x > x3 && x < x4 && y > y3 && y < y4);

            bool isInTopLine = y == 4 * h && x >= h && x <= 2 * h;

            bool isInTopSideLines = (x == h || x == 2 * h)
                                      && y >= h
                                      && y <= 4 * h;

            bool isInMiddleLines = y == h
                                    && ((x >= 0 && x <= h) || (x >= 2 * h && x <= 3 * h));
            bool isInBottomLines = (x == 0 || x == 3 * h) && (y >= 0 && y <= h);
            bool isInBottomLine = y == 0 && (x >= 0 && x <= 3 * h);

            if (isInsideFirstRect || isInsideSecondRect || (y == h && x > h && x < 2 * h))
            {
                Console.WriteLine("inside");
            }
            else if (isInTopLine || isInTopSideLines || isInMiddleLines || isInBottomLine || isInBottomLines)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}