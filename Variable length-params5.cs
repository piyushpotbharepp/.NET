// Understanding Variable Length Parameter List 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static long AddList(params long[] v)
        {
            long total, i;
            for(i = 0, total = 0; i < v.Length; i++)
            {
                total += v[i];
            }
            return total;
        }
        static void Main()
        {
            long x = AddList(32, 32, 45, 54, 87, 98, 65, 34, 65, 34, 32, 98, 65, 45);
            Console.WriteLine("Value Of Variable X : " +x);
            Console.ReadLine();
        }
    }
}
