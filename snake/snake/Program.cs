﻿using System;
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
            point p1 = new point();

            p1.x = 5;
            p1.y = 2;
            p1.sym = '*';
            p1.draw();

            point p2 = new point();
            p2.x = 2;
            p2.y = 7;
            p2.sym = '#';
            p2.draw();

            Console.ReadLine();

        }
    }
}
