// Understanding Pass By Reference - Swap
// >>  Changes made in the method affect the caller  
// >>  Assign parameter value before calling the method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void SwapByRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main()
        {
            int i = 2, j = 3;
            System.Console.WriteLine("i = {0}  j = {1}", i, j);

            SwapByRef(ref i, ref j);

            System.Console.WriteLine("i = {0}  j = {1}", i, j);

            System.Console.ReadKey();
        }
    }

}