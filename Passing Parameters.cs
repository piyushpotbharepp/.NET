﻿// Understanding Passing Parameters 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg;
            arg = 4;
            squareVal(arg);
            Console.WriteLine(arg);
            
            arg = 4;
            squareRef(ref arg);
            Console.WriteLine(arg);
        }

        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
        }

        static void squareRef(ref int refParameter)
        {
            refParameter *= refParameter;
        }
    }

}
