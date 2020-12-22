using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class HorizontalLine : SymbolicEntity
    {
        public HorizontalLine(int xRight, int xLeft, int y, char sym)
        {
            points = new List<Point>();
            for (int x = xRight; x < xLeft; x++)
            {
                points.Add(new Point(x, y, sym));
            }
        }
    }
}
