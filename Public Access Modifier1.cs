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
    class PublicTest
    {
        public string name = "Piyush Sahare";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello1" + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest publictest = new PublicTest();
            // Accessing the public variables
            Console.WriteLine("Hello2" + publictest.name);
            //Accessing the public function
            publictest.Msg("Hello3");
            Console.ReadLine();
        }
    }
}
