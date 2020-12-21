using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Snake : Line
    {
        public int Lenth { get { return points.Count; } }
        public Direction Direction { get; private set; } 
        public Snake(Point head, int lenth, Direction direction)
        {
            points = new List<Point>();
            Direction = direction;
            for (int i = 0; i < lenth; i++)
            {
                Point point = new Point(head);
                point.Move(i, direction);
                points.Add(point);
            }
        }
        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.Collision(food))
            {
                food.Symbol = head.Symbol;
                food.Draw();
                points.Add(food);
                return true;
            }
            return false;
        }

        public bool TailCollision()
        {
            Point head = points[Lenth - 1];
            for (int i = 0; i < Lenth - 2; i++)
            {
                if (head.Collision(points[i]))
                    return true;
            }
            return false;
        }
        public void Move()
        {
            Point tail = points[0];
            Point head = GetNextPoint();
            points.Remove(tail);
            tail.Clear();
            points.Add(head);
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = points[Lenth - 1];
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void KeyHandler(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.RightArrow: { Direction = Direction.RIGHT; break; }
                case ConsoleKey.LeftArrow: { Direction = Direction.LEFT; break; }
                case ConsoleKey.UpArrow: { Direction = Direction.UP; break; }
                case ConsoleKey.DownArrow: { Direction = Direction.DOWN; break; }
            }
        }
    }
}
