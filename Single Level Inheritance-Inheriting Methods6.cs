/*
=========================================================
                  INHERITANCE 
=========================================================
 >> When one class inherits another class with methods 
    is known as single level inheritance
 .................................................
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class person
    {
        public string name = "Piyush";
        public string address = "Nagpur";
    }
    class employee : person
    {
        public int salary = 79000;
        public string designation = "Manager";
    }
    class Program
    {
        public static void Main()
        {
            employee emp = new employee();

            Console.WriteLine("Employee Name : " + emp.name);
            Console.WriteLine("Employee Address : " + emp.address);
            Console.WriteLine("Employee Salary : " + emp.salary);
            Console.WriteLine("Emoployee Designation : " + emp.designation);

            Console.ReadLine(); 
        }
    }
}