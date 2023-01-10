using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class QuotientAndRemainder
    {
        public static void ComputeQuotientAndRemainder()
        {
            Console.WriteLine("C# Program to Compute Quotient and Remainder");
            Console.Write("Enter the Number Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Number Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient : " + quotient);
            Console.WriteLine("Remainder : " + remainder);
        }
    }
}
