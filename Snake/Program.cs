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

            VerticalLine v1 = new VerticalLine(5, 0, 10, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorisontalLine h1 = new HorisontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }

            Console.ReadLine();            
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
