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

            Console.ReadLine();
        }
    }
}
