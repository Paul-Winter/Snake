using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine line = new HorisontalLine(5, 10, 8, '+');
            line.Draw();

            VerticalLine vLine = new VerticalLine(10, 1, 10, '*');
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
