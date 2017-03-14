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
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
                        vLine vLeftline = new vLine(0, 0, 24, '+');
                        vLeftline.drow();

                        vLine vRigntline = new vLine(79, 0, 24, '+');
                        vRigntline.drow();

                        hLine hUpline = new hLine(1, 78, 0, '+');
                        hUpline.drow();

                        hLine hDownline = new hLine(0, 79, 24, '+');
                        hDownline.drow();

            point p = new point(5,5,'*');
            p.draw();


            Console.ReadLine();

        }
    }
}
