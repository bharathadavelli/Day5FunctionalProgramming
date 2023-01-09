using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class Leapyear
    {
        public static void IsLeapYear()
        {
            Console.WriteLine("Enter a four digit year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(year  + "It is a leap year");
            }
            else
            {
                Console.WriteLine(year  + "It is not a leap year");
            }
            }
        }
    }
