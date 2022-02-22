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
    public class Program1
    {
        string name;
        int roll_no;

        public void GetProgram1(string name, int roll_no)
        {
            this.name = name;
            this.roll_no = roll_no;
        }

        public void DisplayProgram1()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll Number : "  + roll_no);
        }
    }
    public class Program2 : Program1
    {
        string college_name;
        int college_registration_no;

        public void GetPropgram2(string college_name, int college_registration_no)
        {
            this.college_name = college_name;
            this.college_registration_no = college_registration_no;
        }

        public void DisplayProgram2()
        {
            Console.WriteLine("College Name : " + college_name);
            Console.WriteLine("College Registration Number : " + college_registration_no);
        }
    }
    class Inheritance
    {
        public static void Main()
        {
            Program2 Program = new Program2();

            Program.GetProgram1("Himanshu Navghare", 68);
            Program.GetPropgram2("Binzani College", 6788767);

            Program.DisplayProgram1();
            Program.DisplayProgram2();

            Console.ReadLine();
        }
    }
}