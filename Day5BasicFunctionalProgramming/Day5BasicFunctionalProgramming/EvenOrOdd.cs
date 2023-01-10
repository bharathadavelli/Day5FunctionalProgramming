using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class EvenOrOdd
    {
        public static void OddorEven()
        {
            Console.WriteLine("C# Program to Check Whether a Number is Even or Odd");
            Console.Write("Enter the number you want to check : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}

