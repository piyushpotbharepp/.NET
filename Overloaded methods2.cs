/* Understanding the Overloaded Methods 
--------------------------------------------------------------
>>  Method overloading is the common way of implementing polymorphism
    It is the ability to redefine a function in more than one form.
>>  A user can implement function overloading by defining two or 
    more functions in a class sharing the same name. 
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
        static int Add(int a, int b, int c)
        {
            return (a + b) + c;
        }
        static int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        static void Main()
        {
            Console.WriteLine("Addition of 1 Number" + Add(1));
            Console.WriteLine("Addition of 2 Numbers : " + Add(22, 32));
            Console.WriteLine("Addiyion of 3 Numbers : " + Add(55, 23, 32));
            Console.WriteLine("Addition of 4 Numbers : " + Add(32, 56, 87, 25));
            Console.ReadLine();
        }
    }

}
