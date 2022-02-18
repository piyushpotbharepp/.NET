/* Understanding Rank Property[ One Dimensional ] 
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
            string[] Name;

            Name = new string[] { "Piyush", "Krunal", "Mahesh", "Vivek", "Himanshu", "Pawan", "Nikunj" };

            Console.WriteLine("Dimesion Of weekDays Array : " + Name.Rank);

            Console.ReadLine();
        }

    }
}