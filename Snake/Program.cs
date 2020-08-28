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

            int speed = 250;
            int score = 0;

            Wall wall = new Wall(80, 25);
            Console.ForegroundColor = ConsoleColor.Yellow;
            wall.Draw();

            Point tail = new Point(4, 5, '%');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            Console.ForegroundColor = ConsoleColor.Green;
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Red;
            food.Draw();

            Message message = new Message();

            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    while (snake.head.IsHit(food))
                    {
                        food = foodCreator.CreateFood();
                        Console.ForegroundColor = ConsoleColor.Red;
                        food.Draw();
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    snake.Draw();
                    speed -= 5;
                    score++;
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(speed);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handler(key.Key);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            message.topLine.Draw();
            message.bottomLine.Draw();
            Console.SetCursorPosition(27, 10);
            Console.Write(message.text);
            Console.SetCursorPosition(32, 12);
            Console.Write($@"your score is {score}");
            Console.SetCursorPosition(28, 14);
            Console.Write(message.author);
            Console.ReadKey();
        }
    }
}
