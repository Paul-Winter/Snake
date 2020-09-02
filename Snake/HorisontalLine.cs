using System.Collections.Generic;


namespace Snake
{
    class HorisontalLine: Figure
    {
        /// <summary>
        /// Метод рисует горизонтальную линию.
        /// В качестве аргументов принимает: координату Х левой точки, координату Х правой точки,
        /// координату Y и символ, которым будет нарисована линия
        /// </summary>
        /// <param name="xLeft"></param>
        /// <param name="xRight"></param>
        /// <param name="y"></param>
        /// <param name="sym"></param>
        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }
    }
}
