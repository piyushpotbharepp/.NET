﻿// Write a program to accept radius of sphere
// and print the volume of the sphere

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
            double r, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF SPHERE");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Radius of the sphere : ");
            r = Convert.ToInt32(Console.ReadLine());
            
            vol = 4/3 * 3.14 * r * r * r;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Volume of the Sphere : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
