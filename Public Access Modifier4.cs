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
        string Branch = "Electronics Engineering";
        //Brach is automatically taken as Private Access Modifier 
        public string Section = "A";
        int Roll_Number = 53;
        //Roll_Number is automatically taken as Private Access Modifier
        public string Registration_Number = "AETX1117045";
        int Addmission_Number = 90898;
        //Addmission_Number is automatically taken as Private Access Modifier
        public string Email_Address = "bopche_piyush.ex@ghrce.raisoni.net";
    }
    class Program
    {
        static void Main()
        {
            name detail = new name();
            Console.WriteLine(detail.Name);
            Console.WriteLine(detail.Branch);
            //Brach is automatically taken as Private Access Modifier 
            Console.WriteLine(detail.Section);
            Console.WriteLine(detail.Roll_Number);
            //Roll_Number is automatically taken as Private Access Modifier
            Console.WriteLine(detail.Registration_Number);
            Console.WriteLine(detail.Addmission_Number);
            //Addmission_Number is automatically taken as Private Access Modifier
            Console.WriteLine(detail.Email_Address);
            Console.ReadLine();
        }
    }
}
