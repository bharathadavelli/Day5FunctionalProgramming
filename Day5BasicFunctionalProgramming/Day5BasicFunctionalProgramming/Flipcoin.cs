using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class Flipcoin
    {
        public static void HeadsorTails()
        {
            double NumberOfTimesCoin, headCount = 0, tailCount = 0;
            Console.WriteLine("Enter the positive number of times you want to flip a coin : ");
            NumberOfTimesCoin = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < NumberOfTimesCoin; i++)
            {
                double coin = random.Next(0, 2);
                double num = coin / 2;
                Console.WriteLine(num);
                if (num < 0.5)
                {
                    Console.WriteLine("Tail");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
            }
            //calculating % of Head & % of Tail
            double perHead = (headCount / NumberOfTimesCoin) * 100;
            double perTail = (tailCount / NumberOfTimesCoin) * 100;
            Console.WriteLine("Percetage Head is {0} and Percentage Tail is {1}", perHead, perTail);

        }
    }
}
