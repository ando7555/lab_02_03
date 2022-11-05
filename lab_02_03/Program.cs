using System;

namespace Ex_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, max = 20;

            while (x < max)
            {
                if (x % 2 == 0)
                
                    Console.WriteLine("while: " + x);
                    x++;
                
            }

     /**       do
            {
                if (y % 2 == 0)
                {
                    Console.WriteLine("do while: " + y);
                    y++;

                }
            } while (y < max); */
        }

    }

    }