using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_03
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            // Array initialization #1
            double[] tab1 = new double[3];
            tab1[0] = 2.0;
            tab1[1] = 3.0;
            tab1[2] = 5.0;
            // Array initialization #2
            char[] tab2 = { 'W', 'S', 'E', 'I' };
            // char[] tab2 = new char[] { 'W', 'S', 'E', 'I' };
            // char[] tab2 = new char[4] { 'W', 'S', 'E', 'I' };
            // Array initialization #3
            int[] tab3 = new int[10000];
            Random rnd = new Random();
            for (int i = 0; i < tab3.Length; i++)
            {
                tab3[i] = rnd.Next(0, 2);
                Console.Write(tab3[i]);
            }
        }
    }


}
