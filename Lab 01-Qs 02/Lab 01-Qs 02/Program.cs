using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Qs_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area} square units.");

            Console.ReadLine();

        }
    }
}
