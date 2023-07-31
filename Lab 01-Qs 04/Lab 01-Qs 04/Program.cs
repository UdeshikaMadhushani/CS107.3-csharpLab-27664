using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Qs_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the tax rate (in %): ");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            double tax = salary * (taxRate / 100);

            double salaryAfterTax = salary - tax;

            Console.WriteLine($"The salary after a tax of {taxRate}% is {salaryAfterTax}.");

            Console.ReadLine();

        }
    }
}
