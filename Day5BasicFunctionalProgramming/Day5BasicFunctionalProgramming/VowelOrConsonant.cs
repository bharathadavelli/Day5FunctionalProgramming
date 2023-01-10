using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5BasicFunctionalProgramming
{
    internal class VowelOrConsonant
    {
        public static void checkVowel()
        {
            Console.WriteLine("C# Program to Check Whether an Alphabet is Vowel or Consonant");
            Console.Write("Please enter the alphabet : ");
            char alphabet = (char)Console.Read();
            if (alphabet == 'A' || alphabet == 'I' || alphabet == 'E' || alphabet == 'O' || alphabet == 'U' || alphabet == 'a' || alphabet == 'i' || alphabet == 'e' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine(" Alphabet " + alphabet + " is vowel");
            }
            else
            {
                Console.WriteLine(" Alphabet " + alphabet + " is consonent");
            }
        }
    }
}
