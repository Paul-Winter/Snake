using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int speed = 250;
            Message message = new Message();

            #region Установка размеров окна и видимости курсора
            
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            #endregion

            #region Отрисовка стен
            
            Wall wall = new Wall(80, 25);
            Console.ForegroundColor = ConsoleColor.Yellow;
            wall.Draw();

            #endregion

            #region Отрисовка змейки
            
            Point tail = new Point(4, 5, '%');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            Console.ForegroundColor = ConsoleColor.Green;
            snake.Draw();

            #endregion

            #region Отрисовка еды
            
            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Red;
            food.Draw();

            #endregion

            #region Игра

            while (true)
            {
                //  проверка столкновения змейки со стенами и со своим телом
                if (wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                //  проверка когда змейка съедает еду
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

                //  управление змейкой с клавиатуры
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handler(key.Key);
                }
            }

            #endregion

            #region Отрисовка окончания игры

            Console.ForegroundColor = ConsoleColor.Yellow;
            message.topLine.Draw();
            message.bottomLine.Draw();
            Console.SetCursorPosition(27, 10);
            Console.Write(Message.text);
            Console.SetCursorPosition(32, 12);
            Console.Write($@"your score is {score}");
            Console.SetCursorPosition(28, 14);
            Console.Write(Message.author);
            Console.WriteLine("\a\a\a");
            Console.ReadKey();

            #endregion
        }
    }
}
