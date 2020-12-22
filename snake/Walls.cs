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

        public bool Collision(SymbolicEntity entity)
        {
            foreach (var wall in walls)
            {
                if (wall.Collision(entity))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (SymbolicEntity entity in walls)
            {
                entity.Draw();
            }
        }
    }
}
