// Write a program to accept radius and height of cylinder
// and print the surface of the cylinder

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
            double r, h, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF CYLINDER");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Radius of the cylinder : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the cylinder : ");
            h = Convert.ToInt32(Console.ReadLine());

            area = (2 * 3.14 * r * h) + (2 * 3.14 * r * r);

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Cylinder : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
