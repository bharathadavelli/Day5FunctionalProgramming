using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class Factors
    {
        public static void primefactors()
        {
            Console.WriteLine("Prime Factors of the number Program");
            Console.Write("Enter the number the Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Factors are : ");
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            for (int i = 3; i * i <= n; i += 2)
            {

                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            if (n > 2)
                Console.Write(n);
        }
    }
}
