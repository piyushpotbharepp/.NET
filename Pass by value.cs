// Understanding Pass By Value 
// >>  Variable can be changed inside the method 
// >>  Has no effect on value outside the method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void AddOne(int x)
        {
            x++;
            Console.WriteLine("Value inside AddOne Method is : " + x);//Output will be 6
        }
        static void main()
        {
            int p = 5;
            AddOne(p);
            Console.WriteLine(p);//Output will be 5
        }

    }

}
