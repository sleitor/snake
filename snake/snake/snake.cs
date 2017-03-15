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

        internal void move()
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
            point nextpoint = head;
            nextpoint.move(1, direction);
            return nextpoint;
        }
    }
}
