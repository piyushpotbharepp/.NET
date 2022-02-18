/* Understanding Method Signatures  
--------------------------------------------------------------
>>  Method must be unique within the class 
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
        static int Add(int a)
        {
            return a;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static long Add(int a, long b)
        {
            return a + b;
        }
       // Same methods with same parameters can not be called. 
       // It will show an error.
       // You have to change the prameter to run the code.
        static void Main()
        {
            Console.WriteLine("Addition of 1 Number : " + Add(1));
            Console.WriteLine("Addition of 2 Numbers : " + Add(22, 32));
            Console.WriteLine("Addiyion of 3 Numbers : " + Add(55, 23L));
            
            Console.ReadLine();
        }
    }

}
