// Write a program to accept length, width and height of rectangular solid
// and print the volume of the rectangular solid

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
            double l, w, h, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF RECTANGULAR SOLID");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Length of the rectangular solid : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of the rectangular solid : ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the rectangular solid : ");
            h = Convert.ToInt32(Console.ReadLine());

            vol = l * w * h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Volume of the Rectangular Solid : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}