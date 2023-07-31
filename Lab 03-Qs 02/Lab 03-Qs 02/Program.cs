using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Qs_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();

            input = input.ToLower();

            int vowelCount = 0;
            foreach (char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"The string contains {vowelCount} vowel(s).");

            Console.ReadLine();

        }
    }
}
