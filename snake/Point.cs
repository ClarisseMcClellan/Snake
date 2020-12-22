using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Point
    {
        public int PositionLeft { get; set; }
        public int PositionTop { get; set; }
        public char Symbol { get; set; }

        public Point() { }
        
        public Point(int x, int y, char sym)
        {
            PositionLeft = x;
            PositionTop = y;
            Symbol = sym;
        }

        public Point (Point p)
        {
            PositionLeft = p.PositionLeft;
            PositionTop = p.PositionTop;
            Symbol = p.Symbol;
        }

        public bool Collision(Point point) => PositionLeft == point.PositionLeft && PositionTop == point.PositionTop;
        public void Clear()
        {
            Symbol = ' ';
            Draw();
        }

        public void Move(int offset, Direction direction)
        {
            switch ((int)direction)
            {
                case 0: { PositionLeft += offset; break; }
                case 1: { PositionLeft -= offset; break; }
                case 2: { PositionTop -= offset; break; }
                case 3: { PositionTop += offset; break; }
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(PositionLeft, PositionTop);
            Console.Write(Symbol);
        }
    }
}
