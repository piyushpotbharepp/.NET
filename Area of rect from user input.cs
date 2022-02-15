// Write a program to accept length and breadth of a rectangle
// and print the area of the rectangle

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
            int l, b, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF RECTANGLE");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the length of the rectangle : ");
            l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the rectangle : ");
            b=Convert.ToInt32(Console.ReadLine());
           
            area = l*b;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the rectangle : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
