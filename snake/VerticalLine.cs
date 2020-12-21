using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class VerticalLine : Line
    {
        public VerticalLine(int yTop, int yDown, int x, char sym)
        {
            points = new List<Point>();
            for (int y = yTop; y < yDown; y++)
            {
                points.Add(new Point(x, y, sym));
            }
        }
    }
}
