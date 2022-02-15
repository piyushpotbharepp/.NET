// Write a program to accept length, width and height of rectangular solid
// and print the surface of the rectangular solid

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
            double l, w, h, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF RECTANGULAR SOLID");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Length of the rectangular solid : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of the rectangular solid : ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the rectangular solid : ");
            h = Convert.ToInt32(Console.ReadLine());
           
            area = (2*l*w) + (2*l*h) + (2*w*h);

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Rectangular Solid : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
