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
        static void AddOne(out int x)
        {
            x = 10;
            x++;
            Console.WriteLine("Rate Of Intrest : " + x);
            Console.ReadLine();
        }
        static void Main()
        {
            int roi;
            AddOne(out roi);
            Console.WriteLine("Rate Of Intrest : " + roi);
            Console.ReadLine();

        }
    }
}