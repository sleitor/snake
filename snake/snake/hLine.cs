using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class hLine
    {
        List<point> hlist;

        public hLine(int xl, int xr, int y, char sym)
        {

            hlist = new List<point>();

            for (int x = xl; x <= xr; x++)
            {
                point p = new point(x, y, sym);
                hlist.Add(p);
            }


        }
        public void drow ()
        {
            foreach (point p in hlist)
            {
                p.draw();
            }

        }
    }
}
