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

            // отрисовка рамки
            HorisontalLine topLine = new HorisontalLine(0, 78, 0, '+');
            HorisontalLine bottomLine = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rigthLine = new VerticalLine(78, 0, 24, '+');

            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rigthLine.Draw();

            Point tail = new Point(4, 5, '*');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);

            snake.Draw();
            snake.Move();
            Thread.Sleep(300);

            for (int i = 0; i < 50; i++)
            {
                snake.Move();
                Thread.Sleep(300);
            }

            Console.ReadLine();
        }
    }
}
