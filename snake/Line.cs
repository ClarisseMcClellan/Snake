using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Line
    {
        protected List<Point> points;

        public void Draw()
        {
            foreach (Point p in points)
                p.Draw();
        }

        internal  bool Collision(Line line)
        {
            foreach (Point p in points)
            {
                if (line.Collision(p))
                    return true;
            }
            return false;
        }

        private bool Collision(Point point)
        {
            foreach(Point p in points)
            {
                if (point.Collision(p))
                    return true;
            }
            return false;
        }
    }
}
