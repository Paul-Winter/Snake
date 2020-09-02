using System;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        { 
        }

        /// <summary>
        /// Конструктор точки.
        /// В качестве аргумента принимает точку
        /// </summary>
        /// <param name="point"></param>
        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            sym = point.sym;
        }

        /// <summary>
        /// Конструктор точки.
        /// В качестве аргумента принимает координату Х, координату Y и символ
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="sym"></param>
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        /// <summary>
        /// Метод рисует точку
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        /// <summary>
        /// Метод обнуляет символ точки
        /// </summary>
        public void Clear()
        {
            sym = '\0';
            Draw();
        }

        /// <summary>
        /// Метод двигает точку в заданном направлении.
        /// В качестве аргументов принимает величину "передвижения" координаты и направление
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="direction"></param>
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += offset;
            }
            else if (direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if (direction == Direction.DOWN)
            {
                y += offset;
            }
            else if (direction == Direction.UP)
            {
                y -= offset;
            }
        }

        /// <summary>
        /// Метод проверяет столкновение двух точек.
        /// В качестве аргумента принимает точку
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsHit(Point point)
        {
            return point.x == x && point.y == y;
        }
    }
}