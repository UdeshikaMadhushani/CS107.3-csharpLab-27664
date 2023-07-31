using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Qs_02
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
            double difference = num1 - num2;
            double product = num1 * num2;
            double quotient = num2 != 0 ? num1 / num2 : Double.NaN;

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
            Console.WriteLine($"The difference between {num1} and {num2} is {difference}.");
            Console.WriteLine($"The product of {num1} and {num2} is {product}.");

            if (!Double.IsNaN(quotient))
            {
                Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}.");
            }
            else
            {
                Console.WriteLine($"The second number is zero, division is not possible.");
            }

            Console.ReadLine();

        }
    }
}
