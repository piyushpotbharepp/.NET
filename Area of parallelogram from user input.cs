// Write a program to accept base and height of parallelogram
// and print the area of the parallelogram

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
            int b, h, area;

            Console.WriteLine("================================================================");
            Console.WriteLine("AREA OF PARALLELOGRAM");
            Console.WriteLine("================================================================");

            Console.WriteLine("Enter the Base of the parallelogram : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the parallelogram : ");
            h = Convert.ToInt32(Console.ReadLine());    

            area = b*h;

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Area of the Parallelogram : " + area);
            Console.WriteLine("----------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
