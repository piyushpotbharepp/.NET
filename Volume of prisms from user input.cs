// Write a program to accept base and height of prisms
// and print the volume of the prisms

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
            double b, h, vol;

            Console.WriteLine("================================================================");
            Console.WriteLine("VOLUME OF PRISMS");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Base of the prisms : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the prisms : ");
            h = Convert.ToInt32(Console.ReadLine());

            vol = b * h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Volume of the Prisms : " + vol);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}