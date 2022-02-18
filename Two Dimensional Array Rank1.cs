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
            string[,] Tablero = new string[3, 3];
            Console.WriteLine("Dimesion Of Array : " + Tablero.Rank);

            Console.ReadLine();
        }

    }
}