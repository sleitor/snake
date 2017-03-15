using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;



        public point (int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public point (point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;

        }
        public void move(int i, direction Direction)
    	{
            if (Direction == direction.RIGHT)
            {
                x=x+i;
            }

            if (Direction == direction.LEFT)
            {
                x=x-i;
            }

            if (Direction == direction.UP)
            {
                y=y-i;
            }

            if (Direction == direction.DOWN)
            {
                y=y+i;
            }
        }

        internal void clear()
        {
            sym = ' ';
            draw();
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
