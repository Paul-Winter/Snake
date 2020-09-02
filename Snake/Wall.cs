using System.Collections.Generic;

namespace Snake
{
    class Wall
    {
        List<Figure> wallList;

        /// <summary>
        /// Конструктор создаёт стены по периметру заданной области.
        /// В качестве аргументов принимает ширину и высоту области
        /// </summary>
        /// <param name="mapWidth"></param>
        /// <param name="mapHeight"></param>
        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorisontalLine topLine = new HorisontalLine(0, mapWidth - 2, 0, '+');
            HorisontalLine bottomLine = new HorisontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rigthLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '+');

            wallList.Add(topLine);
            wallList.Add(leftLine);
            wallList.Add(rigthLine);
            wallList.Add(bottomLine);
        }

        /// <summary>
        /// Метод рисует стены
        /// </summary>
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        /// <summary>
        /// Метод проверяет столкновение стены с фигурой.
        /// В качестве аргумента принимает фигуру
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
