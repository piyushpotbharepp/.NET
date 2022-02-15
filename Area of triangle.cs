// Write a program to print the area of the triangle

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
            int b = 4, h = 3, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF TRIANGLE");
            Console.WriteLine("================================================================");

            area = (b * h) / 2;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the Triangle : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
