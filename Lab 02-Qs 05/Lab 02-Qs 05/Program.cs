using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Qs_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Please enter number {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                string result = number % 2 == 0 ? "even" : "odd";

                Console.WriteLine($"The number {number} is {result}.\n");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
