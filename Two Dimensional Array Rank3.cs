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
            string[,] arr = new string[3, 3] {{"1.1","1.2","1.3"},
                                                  {"2.1","2.2","2.3"},
                                                  {"3.1","3.2","3.3"} };
            Console.WriteLine("Dimesion Of Array : " + arr.Rank);

            Console.ReadLine();
        }

    }
}