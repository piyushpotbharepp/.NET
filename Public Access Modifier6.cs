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
        public string Name = "Mohandas Karamchand Gandhi";
        public string Paragraph = "Mohandas Karamchand Gandhi was an Indian lawyer, \nanti-colonial nationalist and political ethicist \nwho employed nonviolent resistance to lead the successful campaign \nfor India's independence from British rule, \nand to later inspire movements for civil rights \nand freedom across the world.";
        void Det()
        {
            Console.WriteLine(Paragraph);
        }
    }
    class Program
    {
        static void Main()
        {
            Details details = new Details();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(details.Name);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(details.Paragraph);

            Console.ReadLine();
        }
    }
}
