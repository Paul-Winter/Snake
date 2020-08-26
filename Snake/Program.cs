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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<char> charList = new List<char>();
            charList.Add('!');
            charList.Add('@');
            charList.Add('#');
            charList.Add('$');
            charList.Add('%');

            foreach (char i in charList)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Point point1 = new Point(numList[0], numList[0], charList[0]);
            Point point2 = new Point(numList[0], numList[1], charList[1]);
            Point point3 = new Point(numList[1], numList[0], charList[2]);
            Point point4 = new Point(numList[1], numList[1], charList[3]);

            List<Point> pointList = new List<Point>();
            pointList.Add(point1);
            pointList.Add(point2);
            pointList.Add(point3);
            pointList.Add(point4);

            foreach(Point point in pointList)
            {
                point.Draw();
            }

            Console.ReadLine();
        }
    }
}
