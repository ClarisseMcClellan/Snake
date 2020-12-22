using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class SymbolicEntity
    {
        protected List<Point> points;

        public void Draw()
        {
            foreach (Point p in points)
                p.Draw();
        }

        internal  bool Collision(SymbolicEntity entity)
        {
            foreach (Point p in points)
            {
                if (entity.Collision(p))
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
