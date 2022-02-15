// Write a program to print the volume of the sphere

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
            double r = 2, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF SPHERE");
            Console.WriteLine("================================================================");

            vol = 4 / 3 * 3.14 * r * r * r;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Volume of the Sphere : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
