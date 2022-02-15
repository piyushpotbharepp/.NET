// Write a program to find the addition of the numbers from the user.

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
            int num1, num2, num3, addition;
            Console.WriteLine("Enter First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            addition = num1 + num2 + num3;

            Console.WriteLine("Addition Of Numbers : " + addition);
            Console.ReadLine();
        }
    }
}
