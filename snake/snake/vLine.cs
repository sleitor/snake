using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class vLine
    {
        List<point> vList;

        public vLine(int x, int yt, int yb, char sym)
        {

            vList = new List<point>();

            for (int y = yt; y <= yb; y++)
            {
                point p = new point(x, y, sym);
                vList.Add(p);
            }


        }
        public void drow()
        {
            foreach (point p in vList)
            {
                p.draw();
            }

        }
    }
}
