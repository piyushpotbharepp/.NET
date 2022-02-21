/*
================================================
                  INHERITANCE 
================================================
           Single Level Inheritance
------------------------------------------------
 >> When one class inherits another class 
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
    }
    public class Student : Person
    {
        public int Roll_number;
        public int Marks;
    }
    class Inheritance
    {
        static void Main()
        {
            Student student = new Student();

            student.Name = "Piyush";
            student.Address = "Shantinagar, Nagpur";
            student.Roll_number = 53;
            student.Marks = 99;

            Console.WriteLine("Name : " + student.Name);
            Console.WriteLine("Address : " + student.Address);
            Console.WriteLine("Roll Number : " + student.Roll_number);
            Console.WriteLine("Marks Obtained : " + student.Marks);

            Console.ReadLine();
        }
    }
}