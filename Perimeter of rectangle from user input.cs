// Write a program to accept length and breadth of a rectangle
// and print the perimeter of the rectangle

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
            int l, b, peri;

            Console.WriteLine("================================================================");
            Console.WriteLine("PERIMETER OF RECTANGLE");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the length of the rectangle : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the rectangle : ");
            b = Convert.ToInt32(Console.ReadLine());

            peri = 2*l * 2*b;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Perimeter of the rectangle : " + peri);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}