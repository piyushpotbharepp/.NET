/*
================================================
                Access Modifiers 
================================================
            Protected Access Modifier
------------------------------------------------
 >> It is accessible within the class and has limited scope
 >> It is also accessible within subclass or child class in case of inheritance
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

        protected void GetPerson(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void DisplayPerson()
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
            //Since Program class is not derived class of Person class
            emp.GetEmployee(67000, "Manager");

            emp.DisplayPerson();
            //Since Program class is not derived class of Person class
            emp.DisplayEmployee();

            Console.ReadLine();
        }
    }
}