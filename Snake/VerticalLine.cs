using System.Collections.Generic;

namespace Snake
{
    class VerticalLine: Figure
    {
        /// <summary>
        /// Метод рисует вертикальную линию.
        /// В качестве аргументов принимает координату Х, координату Y верхней точки,
        /// координату Y нижней точки и символ, которым будет нарисована линия
        /// </summary>
        /// <param name="x"></param>
        /// <param name="yTop"></param>
        /// <param name="yBottom"></param>
        /// <param name="sym"></param>
        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }
    }
}
