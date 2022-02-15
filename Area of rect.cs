// Write a program to print the area of the rectangle

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
            int l = 12, b = 8, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF RECTANGLE");
            Console.WriteLine("================================================================");

            area = l*b;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the rectangle : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
