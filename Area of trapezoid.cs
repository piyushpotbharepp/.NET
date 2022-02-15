// Write a program to print the area of the trapezoid

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
            int b1 = 4, b2 = 3, h = 3, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF TRAPEZOID");
            Console.WriteLine("================================================================");

            area = ((b1 + b2)/2) * h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the Trapezoid : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
