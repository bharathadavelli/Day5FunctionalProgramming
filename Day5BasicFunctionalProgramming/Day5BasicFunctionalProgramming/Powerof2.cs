using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class Powerof2
    {
        public static void powersof2()
        {
            int N;
            do
            {
                Console.WriteLine("Enter the argument N (only values from 0 to 31 : ");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N > 31 || N < 0);
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("2 power {0} is {1} ", i, Math.Pow(2, i));
            }
        }
    }
}
