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
            for(i=0, total=0; i < v.Length; i++)
            {
                total += v[i];
            }
            return total;
        }
        static void Main()
        {
            long x = AddList(24, 74, 32, 11, 89, 67, 98, 43, 23, 87, 34, 23, 34, 45, 65, 32);
            Console.WriteLine("Value Of The Variable X Is : " + x );
            Console.ReadLine();
        }
    }
}
