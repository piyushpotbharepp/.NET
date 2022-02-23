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
        public void getPersonData(string name,string address)
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
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("Roll Number : " + rno);
            Console.WriteLine("Marks : " + marks);
        }
    }
    public class Employee : Person
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary,string designation)
        {
            this.salary = salary;
            this.designation = designation; 
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);
        }
    }
    class Inheritance
    {
        public static void Main()
        {
            Student s1 = new Student();
            s1.getPersonData("Priya","Shantinagar, Nagpur");
            s1.getStudentData(56, 87);
            s1.displayPersonData();
            s1.displayStudentData();

            Employee e1 = new Employee();
            e1.getPersonData("Ramesh", "Mahal Nagpur");
            e1.getEmployeeData(550000, "Manager");
            e1.displayPersonData();
            e1.displayEmployeeData();

            Console.ReadLine();
        }
    }
}