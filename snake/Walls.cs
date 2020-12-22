using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Walls
    {
        private List<SymbolicEntity> walls;

        public Walls(int mapWidth, int mapHeight)
        {
            walls = new List<SymbolicEntity>();
            walls.Add(new VerticalLine(1, mapHeight - 1, 1, '|'));
            walls.Add(new VerticalLine(1, mapHeight - 1, mapWidth - 1, '|'));
            walls.Add(new HorizontalLine(1, mapWidth - 1, 0, '-'));
            walls.Add(new HorizontalLine(1, mapWidth - 1, mapHeight - 1, '-'));
        }

        public bool Collision(SymbolicEntity line)
        {
            foreach (var wall in walls)
            {
                if (wall.Collision(line))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (SymbolicEntity line in walls)
            {
                line.Draw();
            }
        }
    }
}
