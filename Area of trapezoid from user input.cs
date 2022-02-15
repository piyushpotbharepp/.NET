// Write a program to accept first base, second base and height of trapezoid
// and print the area of the trapezoid

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
            int b1, b2, h, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF TRAPEZOID");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the First Base of the trapezoid : ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Base of the trapezoid : ");
            b2 = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Enter the Height of the triangle : ");
            h = Convert.ToInt32(Console.ReadLine());    

            area = ((b1+b2)/2)*h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the Trapezoid : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
