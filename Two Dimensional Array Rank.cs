/* Understanding Rank Property[ Two Dimensional ] 
--------------------------------------------------------------
>>  The rank is the numbers of dimensions of an array 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            int[,] arr2 = new int[4, 8];

            Console.WriteLine("Dimesion Of Array : " + arr2.Rank);

            Console.ReadLine();
        }

    }
}