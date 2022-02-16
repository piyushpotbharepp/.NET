// Understanding Pass By Reference
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
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Variable value before calling the method : " + x);
            Multiplication(ref x);
            Console.WriteLine("Variable value after calling the method : " + x);
            Console.ReadLine();
        }
        public static void Multiplication(ref int a)
        {
            a *= a;
            Console.WriteLine("Variable value inside the method : " + a);
        }
    }
    /*
    If you observe the above example, 
    we are passing the reference of variable x to variable a 
    in the Multiplication method by using the ref keyword. 
    In this case, the variable contains the reference of variable x, 
    so the changes made to variable a will affect variable x.
    */
}
