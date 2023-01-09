using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Day5BasicFunctionalProgramming
{
    internal class HarmonicNumber
    {
        public static void HarmonicofNumber()
        {
            int i, n;
            double s = 0.0;
            Console.WriteLine("Enter a number");
            n=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                s+= 1/(float)i;
            }
                Console.WriteLine("Harmonic value is:"+ s);
        }
    }
}
