// Write a program to accept base, perimeter and height of prisms
// and print the surface of the prisms

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
            double b, p, h, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("SURFACE OF PRISMS");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Base of the prisms : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Perimeter of the prisms : ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the prisms : ");
            h = Convert.ToInt32(Console.ReadLine());

            area = (2 * b) + (p * h);

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Surface of the Prisms : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
