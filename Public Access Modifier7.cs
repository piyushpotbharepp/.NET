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
    class Details
    {
        public string Name = "Understanding Access Modifier - Public";
        public string Info = ">> Public is not restricted." +
                             "\n>> It specifies that access is not restricted." +
                             "\n>> Objects that implement public access modifiers are accessible from" +
                             "\n   everywhere in our project, therefore there is no accessibility restrictions.";
    }
    class Program
    {
        static void Main()
        {
            Details details = new Details();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(details.Name);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(details.Info);

            Console.ReadLine();
        }
    }
}
