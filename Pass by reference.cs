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
            static void AddOne(ref int x)
            {
                x++;
                Console.WriteLine("Value inside AddOne Method is : " + x);//Output will be 6
            }
            static void Main()
            {
                int p = 5;
                AddOne(ref p);
                Console.WriteLine("Value after calling the method in Main is : " + p);//Output will be 6
                Console.ReadLine();
            }

   }

}
