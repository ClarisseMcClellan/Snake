using System;
using System.Threading;

namespace snake
{
    class Program
    {
        public static int mapWidth = 100;
        public static int mapHeight = 30;
        static void Main(string[] args)
        {
            Console.SetWindowSize(mapWidth, mapHeight);
            Console.SetBufferSize(mapWidth, mapHeight);

            Walls walls = new Walls(mapWidth, mapHeight);
            walls.Draw();

            Snake snake = new Snake(new Point(50, 20, '*'), 6, Direction.RIGHT);
            snake.Draw();

            FoodCreatot foodCreatot = new FoodCreatot(mapWidth, mapHeight, '&', '%', '$', '#');
            Point food = foodCreatot.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.Collision(snake) || snake.TailCollision())
                {
                    Console.Beep();
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreatot.CreateFood();
                    food.Draw();
                }
                else snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandler(key.Key);
                }

                Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition((mapWidth / 2) - 4, mapHeight / 2);
            Console.WriteLine(" GAME OVER ");
            Console.ReadKey();
        }
    }
}
