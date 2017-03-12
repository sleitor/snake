using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(5,2,'*');
            p1.draw();

            point p2 = new point(2,7,'#');
            p2.draw();

            List<point> listpoint = new List<point>();
            listpoint.Add(p1);
            listpoint.Add(p2);

            point p3 = new point(1, 2, '%');
            point p4 = new point(3, 5, '@');
            p3.draw();
            p4.draw();


            listpoint.Add(p3);
            listpoint.Add(p4);


            hLine hline = new hLine(5,10,15,'+');
            hline.drow();

            vLine vline = new vLine(1, 2, 5, '/');
            vline.drow();

            Console.ReadLine();

        }
    }
}
