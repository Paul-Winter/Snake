using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            Wall wall = new Wall(80, 25);
            Console.ForegroundColor = ConsoleColor.Yellow;
            wall.Draw();

            Point tail = new Point(4, 5, '*');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            Console.ForegroundColor = ConsoleColor.Green;
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Red;
            food.Draw();
            Console.ForegroundColor = ConsoleColor.Green;

            Message message = new Message();

            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    Console.ForegroundColor = ConsoleColor.Red;
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.Green;
                    snake.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handler(key.Key);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            message.topLine.Draw();
            Console.SetCursorPosition(27, 10);
            Console.Write(message.text);
            Console.SetCursorPosition(34, 12);
            Console.Write(message.cb);
            Console.SetCursorPosition(33, 14);
            Console.Write(message.author);
            message.bottomLine.Draw();
            Console.ReadKey();
        }
    }
}
