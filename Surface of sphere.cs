// Write a program to print the surface of the sphere

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
            double r = 2, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF SPHERE");
            Console.WriteLine("================================================================");

            area = 4 * 3.14 * r * r;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Sphere : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
