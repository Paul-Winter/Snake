using System;


namespace Snake
{
    class FoodCreator
    {
        private char sym;
        private int mapWidth;
        private int mapHeight;
        static Random random = new Random();

        /// <summary>
        /// Конструктор "еды" для змейки
        /// </summary>
        /// <param name="mapWidth"></param>
        /// <param name="mapHeight"></param>
        /// <param name="sym"></param>
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        /// <summary>
        /// Метод создаёт "еду" для змейки.
        /// Присваивает случайные координаты в пределах заданной области
        /// </summary>
        /// <returns></returns>
        internal Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
