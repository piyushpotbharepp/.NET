// Write a program to accept radius and height of cylinder
// and print the Volume of the cylinder

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
            double r, h, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF CYLINDER");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Radius of the cylinder : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the cylinder : ");
            h = Convert.ToInt32(Console.ReadLine());

            vol = 3.14 * r * r * h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Volume of the Cylinder : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}