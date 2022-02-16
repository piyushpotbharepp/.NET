// Understanding Using Variable Length Parameter List 
// >>  Use the params keyword
// >>  Declare as an array at the end of the parameter  list
// >>  Always pass by value

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static long AddList(params long[] v)
        {
            long total, i;
            for(i=0,total=0; i < v.Length; i++)
            {
                total += v[i];
            }
            return total;
        }
        static void Main()
        {
            long x = AddList(34, 45, 87);
            Console.WriteLine("Value of x : " + x);
            Console.ReadLine();
        }
    }
}