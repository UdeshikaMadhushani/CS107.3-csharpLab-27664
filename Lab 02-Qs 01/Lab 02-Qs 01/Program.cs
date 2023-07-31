using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Qs_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

            Console.ReadLine();

        }
    }
}
