using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }

        public Point() { }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Symbol = sym;
        }

        public Point (Point p)
        {
            X = p.X;
            Y = p.Y;
            Symbol = p.Symbol;
        }

        public bool Collision(Point point) => X == point.X && Y == point.Y;
        public void Clear()
        {
            Symbol = ' ';
            Draw();
        }

        public void Move(int offset, Direction direction)
        {
            switch ((int)direction)
            {
                case 0: { X += offset; break; }
                case 1: { X -= offset; break; }
                case 2: { Y -= offset; break; }
                case 3: { Y += offset; break; }
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }
    }
}
