using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class hLine : figure
    {

        public hLine(int xl, int xr, int y, char sym)
        {

            pList = new List<point>();

            for (int x = xl; x <= xr; x++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }


        }
    }
}
