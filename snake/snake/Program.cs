using System;
using System.Threading;
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
            Console.CursorVisible = false;
            vLine vLeftline = new vLine(0, 0, 24, '+');
            vLeftline.drow();

            vLine vRigntline = new vLine(79, 0, 24, '+');
            vRigntline.drow();

            hLine hUpline = new hLine(1, 78, 0, '+');
            hUpline.drow();

            hLine hDownline = new hLine(0, 79, 24, '+');
            hDownline.drow();

            point p = new point(5,5,'*');
            snake Snake = new snake(p, 2, direction.RIGHT);
            Snake.drow();

            while (true)
            {
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = direction.LEFT;
                    if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = direction.RIGHT;
                    if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = direction.UP;
                    if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = direction.DOWN;

                }
                Thread.Sleep(100);
                Snake.move();
            }

            Console.ReadLine();

        }
    }
}
