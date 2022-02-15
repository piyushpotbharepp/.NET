// Write a program to print the volume of the rectangular solid

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
            double l = 20, w = 10, h = 25, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF RECTANGULAR SOLID");
            Console.WriteLine("================================================================");

            vol = l * w * h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Volume of the Rectangular Solid : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}