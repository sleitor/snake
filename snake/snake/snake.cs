using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake : figure
    {
        direction direction;

        public snake(point tail, int length, direction _direction)
        {
            direction = _direction;
            pList = new List<point>();
            for (int i = 0; i < length; i++)
            {
                point p = new point(tail);
                p.move(i, direction);
                pList.Add(p);

            }
        }

        public void move()
        {
            point tail = pList.First();
            pList.Remove(tail);
            point head = GetNextPoint();
            pList.Add(head);

            tail.clear();
            head.draw();
            
        }

        private point GetNextPoint()
        {
            point head = pList.Last();
            point nextpoint = new point(head);
            nextpoint.move(1, direction);
            return nextpoint;
        }

        internal void handleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                direction = direction.RIGHT;
            if (key == ConsoleKey.UpArrow)
                direction = direction.UP;
            if (key == ConsoleKey.DownArrow)
                direction = direction.DOWN;


        }
    }
}
