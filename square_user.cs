// Write a program to accept number from the user and print the square.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sq;
            Console.WriteLine("Enter Number :");
            num = Convert.ToInt32(Console.ReadLine());
            sq = num * num;
            Console.WriteLine("Square : " + sq);
            Console.ReadLine(); 


        }
    }
}
