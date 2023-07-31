using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_Qs_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"The area of the circle with radius {radius} is {area} square units.");
            Console.WriteLine($"The circumference of the circle with radius {radius} is {circumference} units.");

            Console.ReadLine();

        }
    }
}
