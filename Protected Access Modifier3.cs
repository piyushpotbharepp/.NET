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
    public class Program1
    {
        string name;
        int roll_no;

        protected void GetProgram1(string name, int roll_no)
        {
            this.name = name;
            this.roll_no = roll_no;
        }

        protected void DisplayProgram1()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll Number : " + roll_no);
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
            //Since Inheritance class is not derived class of Program1 class
            Program.GetPropgram2("Binzani College", 6788767);

            Program.DisplayProgram1();
            //Since Inheritance class is not derived class of Program1 class
            Program.DisplayProgram2();

            Console.ReadLine();
        }
    }
}