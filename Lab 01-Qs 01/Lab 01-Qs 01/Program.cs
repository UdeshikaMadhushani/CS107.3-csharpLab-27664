using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Qs_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your batch: ");
            string batch = Console.ReadLine();

            Console.WriteLine($"Your name is {name} and your batch is {batch}.");

            Console.ReadLine();

        }
    }
}
