// Write a program to print the surface of the prisms

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
            double b = 20, p = 10, h = 25, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF PRISMS");
            Console.WriteLine("================================================================");

            area = (2 * b) + (p * h);

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Prisms : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
