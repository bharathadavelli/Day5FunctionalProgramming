using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class SwapTwoNumbers
    {
        public static void Swap()
        {
            Console.WriteLine("C# Program to Swap Two Numbers");
            Console.Write("Enter the value of A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B : ");
            int B = Convert.ToInt32(Console.ReadLine());
            int swapNum = A;
            A = B;
            B = swapNum;
            Console.WriteLine("Value of A after swapping : " + A);
            Console.WriteLine("Value of B after swapping : " + B);
        }
    }
}
