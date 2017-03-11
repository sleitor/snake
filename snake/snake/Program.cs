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

            Console.ReadLine();

        }
    }
}
