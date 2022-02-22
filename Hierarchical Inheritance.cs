/*
================================================
                INHERITANCE 
================================================
            Hierarchical Inheritance
------------------------------------------------
 >> Hierarchical Inheritance is a kind of inheritance 
    where more than one class is inherited from 
    a single parent or base class.
 .................................................
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Person
    {
        string name;
        string address;
        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }

    }
    public class Student : Person
    {
        int Roll_Number;
        int Marks;
        public void getStudentData(int Roll_Number, int Marks)
        {
            this.Roll_Number = Roll_Number;
            this.Marks = Marks;
        }
        public void diplayStudentData()
        {
            Console.WriteLine("Roll Number : " + Roll_Number);
            Console.WriteLine("Marks : " + Marks); 
        }
    }
    public class Employee : Person
    {
        int Salary;
        string Designation;
        public void getEmployeeData(int Salary,string Designation)
        {
            this.Salary = Salary;
            this.Designation = Designation; 
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("Salary : " + Salary);
            Console.WriteLine("Designation : " + Designation);
        }

    }
    class Inheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.getPersonData("Piyush", "Shantinagar Nagpur");
            p1.getStudentData(55,98);
            p1.displayPersonData();
            p1.diplayStudentData();

            Employee p2 = new Employee();
            p2.getPersonData("Raghav", "Pune, Maharashtra");
            p2.getEmployeeData(550000, "Manager");
            p2.displayPersonData();
            p2.displayEmployeeData();

            Console.ReadLine();
        }
    }
}