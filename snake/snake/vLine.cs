using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class vLine : figure
    {

        public vLine(int x, int yt, int yb, char sym)
        {

            pList = new List<point>();

            for (int y = yt; y <= yb; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }


        }
    }
}
