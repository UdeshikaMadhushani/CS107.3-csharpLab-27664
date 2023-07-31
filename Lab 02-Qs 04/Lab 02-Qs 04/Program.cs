using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Qs_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = number % 2 == 0 ? "even" : "odd";

            Console.WriteLine($"The number {number} is {result}.");

            Console.ReadLine();

        }
    }
}
