// Write a program to print the volume of the cylinder

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
            double r = 5, h = 4, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF CYLINDER");
            Console.WriteLine("================================================================");

            vol = 3.14 * r * r * h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("volume of the Cylinder : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}