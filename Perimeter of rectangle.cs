// Write a program to print the perimeter of the rectangle

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double l = 12, b = 8, peri;

            Console.WriteLine("================================================================");
            Console.WriteLine("PERIMETER OF RECTANGLE");
            Console.WriteLine("================================================================");

            peri = 2*l * 2*b;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Perimeter of the rectangle : " + peri);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}