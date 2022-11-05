using System;
namespace Ex_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x, printNumber = 0;
            while (printNumber < 20)
            {
                x = rnd.Next(0, 1000);
                if (x % 2 == 1)
                    continue; // if x is odd, jump to the next round (iteration)
                printNumber++;
                Console.WriteLine("number {0}: {1}", printNumber, x);
            }
        }
    }
}
