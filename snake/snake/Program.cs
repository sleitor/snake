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

            List<int> num = new List<int>();

            num.Add(0);
            num.Add(1);
            num.Add(2);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            num.RemoveAt(0);

            List<point> listpoint = new List<point>();
            listpoint.Add(p1);
            listpoint.Add(p2);

            point p3 = new point(1, 2, '%');
            point p4 = new point(3, 5, '@');

            listpoint.Add(p3);
            listpoint.Add(p4);

            Console.ReadLine();

        }
    }
}
