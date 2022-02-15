// Write a program to accept radius of sphere
// and print the surface of the sphere

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
            double r, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF SPHERE");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Radius of the sphere : ");
            r = Convert.ToInt32(Console.ReadLine());
            
            area = 4 * 3.14 * r * r;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Sphere : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
