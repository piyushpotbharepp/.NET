/*
================================================
                  INHERITANCE 
================================================
  Single Level Inheritance - Inheriting Methods
------------------------------------------------
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
    public class Person
    {
        public string Name;
        public string Address;
        public void getPersonalData(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void displayPersonalData()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Address : " + Address);
        }
    }
    public class Student : Person
    {
        int Roll_Number;
        int Marks;
        public void getStudentData( int Roll_Number, int Marks)
        {
            this.Roll_Number = Roll_Number; 
            this.Marks = Marks; 
        }
        public void displayStudentData()
        {
            Console.WriteLine("Roll Number : " + Roll_Number);
            Console.WriteLine("Marks : " + Marks);          
        }
    }
    class Inheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.getPersonalData("Piyush", "Shantinagar");
            p1.getStudentData(111,999);
            p1.displayPersonalData();
            p1.displayStudentData();

            Console.ReadLine();
        }
        
    }
}