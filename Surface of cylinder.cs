// Write a program to print the surface of the cylinder

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
            double r = 5, h = 4, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF CYLINDER");
            Console.WriteLine("================================================================");

            area = (2 * 3.14 * r * h) + (2 * 3.14 * r * r);

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Cylinder : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
