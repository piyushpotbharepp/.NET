// Write a program to print the volume of the prisms

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
            double b = 20, h = 25, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF PRISMS");
            Console.WriteLine("================================================================");

            vol = b * h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Volume of the Prisms : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}