﻿// Write a program to print the area of the circle

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
            int r = 7;
            double area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF CIRCLE");
            Console.WriteLine("================================================================");

            area = 3.14 * r * r;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the Circle : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
