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
    public class Program1_Details 
    {
        string Name;
        int Roll_Number;
        public void GetProgram1Details(string Name, int Roll_Number)
        {
            this.Name = Name;
            this.Roll_Number = Roll_Number;
        }
        public void DisplayProgram1Details()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Roll Number : " + Roll_Number);
        }
    }
    class Program2_Details : Program1_Details
    {
        string Branch;
        string College_Name;
        public void GetProgram2Details(string Branch, string College_Name)
        {
            this.Branch = Branch;
            this.College_Name= College_Name;
        }
        public void DisplayProgram2Details()
        {
            Console.WriteLine("Branch : " + Branch);
            Console.WriteLine("College Name : " + College_Name);
        }
    }
    class Inheritance
    {
        public static void Main()
        {
            Program2_Details Details = new Program2_Details();

            Details.GetProgram1Details("Shweta Sahare", 58);
            Details.GetProgram2Details("Electronics Engineering", "Prerna College Of Engineering");

            Details.DisplayProgram1Details();
            Details.DisplayProgram2Details();

            Console.ReadLine(); 
        }
    }
}