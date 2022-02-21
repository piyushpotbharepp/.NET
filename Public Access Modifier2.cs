/*
================================================
              Access Modifiers 
================================================
           Public Access Modifier
------------------------------------------------
 >> Public is not restricted.
 >> It specifies that access is not restricted.
 >> Objects that implement public access modifiers are accessible from 
    everywhere in our project, therefore there is no accessibility restrictions.
.................................................

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class NumberClass
    {
        public int Number = 23;
    }
    class Program
    {
        static void Main()
        {
            NumberClass numberClass = new NumberClass();    
            Console.WriteLine(numberClass.Number);
        }
    }
}
