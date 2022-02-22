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
    public class Person
    {
        string name;
        int roll_no;

        protected void GetPerson(string name, int roll_no)
        {
            this.name = name;
            this.roll_no = roll_no;
        }

        protected void DisplayPerson()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll Number : " + roll_no);
        }
    }
    public class Employee : Person
    {
        string employee_id;
        int employee_type;

        public void GetEmployee(string employee_id, int employee_type)
        {
            this.employee_id = employee_id;
            this.employee_type = employee_type;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Id : " + employee_id);
            Console.WriteLine("Employee Type : " + employee_type);
        }
    }
    class Inheritance
    {
        public static void Main()
        {
            Employee Program = new Employee();

            Program.GetPerson("Himanshu Navghare", 68);
            //Since Inheritance class is not derived class of Person class
            Program.GetEmployee("gh567", 3);

            Program.DisplayPerson();
            //Since Inheritance class is not derived class of Person class
            Program.DisplayEmployee();

            Console.ReadLine();
        }
    }
}