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
            Console.WriteLine("Variable value before calling the method : " + x);
            Console.ReadLine();
        }
        static void Main()
        {
            int k;
            AddOne(out k);
            Console.WriteLine("Variable value after calling the method in Main : " + k);
            Console.ReadLine();

        }
    }
}
