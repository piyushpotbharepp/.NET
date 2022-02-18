/* Understanding Rank Property[ Jagged Array ] 
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
            int[][] array = new int[10][];
            Console.WriteLine("Dimesion Of Array : " + array.Rank);

            Console.ReadLine();
        }

    }
}