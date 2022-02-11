// Write a program to accept 2 numbers from user
// & print the addition of the number.

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
            int num1,num2,addition;
            Console.WriteLine("Enter the 1st Number :");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number :");
            num2=Convert.ToInt32(Console.ReadLine());   
            addition = num1 + num2; 
            Console.WriteLine("Addition : " + addition);
            Console.ReadLine(); 


        }
    }
}
