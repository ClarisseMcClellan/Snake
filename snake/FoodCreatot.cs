using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class FoodCreatot
    {
        readonly int mapWidth;
        readonly int mapHeight;
        char[] symbol;
        Random random;

        public FoodCreatot(int mapWidth, int mapHeight, params char[] sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            symbol = sym;
            random = new Random();
        }

        public Point CreateFood()
        {
            int positionLeft = random.Next(2, mapWidth - 1);
            int positionTop = random.Next(2, mapHeight - 1);
            int foodSymbolID = random.Next(symbol.Length);
            Point food = new Point(positionLeft, positionTop, symbol[foodSymbolID]);
            return food;
        }
    }
}
