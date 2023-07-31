using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_Qs_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = number % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine($"The number {number} is {result}.");

            Console.ReadLine();

        }
    }
}
