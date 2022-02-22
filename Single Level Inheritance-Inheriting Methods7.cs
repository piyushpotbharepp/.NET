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
        public string name;
        public string address;

        public void GetPerson(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void DisplayPerson()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);  
        }
    }
    class employee : person
    {
        public int salary;
        public string designation;
        public void GetEmployee(int salary, string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);
        }
    }
    class Program
    {
        public static void Main()
        {
            employee emp = new employee();

            emp.GetPerson("Piyush Potbhare", "Shantinagar, Nagpur");
            emp.GetEmployee(67000, "Manager");
           
            emp.DisplayPerson();
            emp.DisplayEmployee();

            Console.ReadLine(); 
        }
    }
}