using System.Collections.Generic;


namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        /// <summary>
        /// Метод рисует фигуру
        /// </summary>
        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }

        /// <summary>
        /// Метод проверяет "столкновение" фигуры с точкой.
        /// В качестве аргумента принимает точку
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод проверяет "столкновение" фигуры с фигурой.
        /// В качестве аргумента принимает фигуру
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
    }
}
