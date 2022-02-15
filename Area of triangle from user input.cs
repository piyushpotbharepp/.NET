// Write a program to accept base and height of triangle
// and print the area of the triangle

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
            int b, h, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF TRIANGLE");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Base of the triangle : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the triangle : ");
            h = Convert.ToInt32(Console.ReadLine());    

            area = (b*h)/2;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the Triangle : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
