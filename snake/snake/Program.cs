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
            int x1 = 5;
            int y1 = 2;
            char sym1 = '*';
            draw(x1, y1, sym1);

            int x2 = 2;
            int y2 = 7;
            char sym2 = '#';
            draw(x2, y2, sym2);
            Console.ReadLine();

        }
        static void draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
