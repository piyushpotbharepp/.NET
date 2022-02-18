/* Understanding Rank Property[ Two Dimensional Array ] 
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
            string[,] Alphabets = new string[3, 3] {{"a","b","c"},
                                                  {"d","e","f"},
                                                  {"g","h","i"} };
            Console.WriteLine("Dimesion Of Array : " + Alphabets.Rank);

            Console.ReadLine();
        }

    }
}