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
    class name
    {
        public string Name = "Piyush Bopche";
        public string Branch = "Electronics Engineering";
        public string Section = "A";
        public int Roll_Number = 53;
        public string Registration_Number = "AETX1117045";
        public int Addmission_Number = 90898;
        public string Email_Address = "bopche_piyush.ex@ghrce.raisoni.net";
    }
    class Program
    {
        static void Main()
        {
            name detail = new name();
            Console.WriteLine(detail.Name);
            Console.WriteLine(detail.Branch);
            Console.WriteLine(detail.Section);
            Console.WriteLine(detail.Roll_Number);
            Console.WriteLine(detail.Registration_Number);
            Console.WriteLine(detail.Addmission_Number);
            Console.WriteLine(detail.Email_Address);
            Console.ReadLine();
        }
    }
}
