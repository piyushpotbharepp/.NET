// Understanding Out Parameter 
// >>  Values are placed out but not in  
// >>  Like ref, but values are not passed into the method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static void Add(out int num1, out int num2)
        {
            num1 = 30;
            num1 += 1;

            num2 = 40;
            num2 += 1;
        }
        static void Main()
        {
            int num1;
            int num2;

            Add(out num1, out num2);
            Console.WriteLine("Num1:", num1);
            Console.WriteLine("Num2:", num2);

            Console.ReadLine();
        }
    }
}