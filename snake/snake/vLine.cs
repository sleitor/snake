using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class vLine : figure
    {

        public vLine(int x, int yTop, int yBottom, char sym)
        {

            pList = new List<point>();

            for (int y = yTop; y <= yBottom; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }


        }
    }
}
