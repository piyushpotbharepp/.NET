// Write a program to print the surface of the rectangular solid

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
            double l = 20, w = 10, h = 25, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF RECTANGULAR SOLID");
            Console.WriteLine("================================================================");

            area = (2 * l * w) + (2 * l * h) + (2 * w * h);

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Rectangular Solid : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
