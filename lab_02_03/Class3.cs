using System;
namespace Ex_02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keep asking until the answer is 'y' or 'n'
            char answer;
            do
            {
                Console.WriteLine("Print the time? y/n");
                answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            while (answer != 'y' && answer != 'n');
            // Print the time if the user decided so
            if (answer == 'y')
                Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
        }
    }
}
