using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            sym = point.sym;
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = '\0';
            Draw();
        }

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

        public bool IsHit(Point point)
        {
            return point.x == this.x && point.y == this.y;
        }
    }
}
