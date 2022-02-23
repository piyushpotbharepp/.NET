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
    public class Mentor
    {
        int Mentor_Id;
        String Mentor_Name;
        int Total_Students_Under_Mentor;

        public void GetMentorData(int Mentor_Id, String Mentor_Name, int Total_Students_Under_Mentor)
        {
            this.Mentor_Id = Mentor_Id;
            this.Mentor_Name = Mentor_Name;
            this.Total_Students_Under_Mentor = Total_Students_Under_Mentor;
        }

        public void DisplayMentorData()
        {
            Console.WriteLine("Mentor ID : " + Mentor_Id);
            Console.WriteLine("Mentor Name : " + Mentor_Name);
            Console.WriteLine("Total Students Under Mentor : " + Total_Students_Under_Mentor);
        }
    }
    public class Student1 : Mentor
    {
        int Roll_Number;
        String Name;
        String Branch;

        public void GetStudent1Data(int Roll_Number, String Name, String Branch)
        {
            this.Roll_Number = Roll_Number;
            this.Name = Name;
            this.Branch = Branch;
        }

        public void DisplayStudnet1Data()
        {
            Console.WriteLine("Roll Number : " + Roll_Number);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Branch : " + Branch);    
        }
    }
    public class Student2 : Mentor
    {
        int Roll_Number;
        String Name;
        String Branch;

        public void GetStudent2Data(int Roll_Number, String Name, String Branch)
        {
            this.Roll_Number = Roll_Number;
            this.Name = Name;
            this.Branch = Branch;
        }

        public void DisplayStudnet2Data()
        {
            Console.WriteLine("Roll Number : " + Roll_Number);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Branch : " + Branch);
        }
    }
    public class Student3 : Mentor
    {
        int Roll_Number;
        String Name;
        String Branch;

        public void GetStudent3Data(int Roll_Number, String Name, String Branch)
        {
            this.Roll_Number = Roll_Number;
            this.Name = Name;
            this.Branch = Branch;
        }

        public void DisplayStudnet3Data()
        {
            Console.WriteLine("Roll Number : " + Roll_Number);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Branch : " + Branch);
        }
    }
    public class Student4 : Mentor
    {
        int Roll_Number;
        String Name;
        String Branch;

        public void GetStudent4Data(int Roll_Number, String Name, String Branch)
        {
            this.Roll_Number = Roll_Number;
            this.Name = Name;
            this.Branch = Branch;
        }

        public void DisplayStudnet4Data()
        {
            Console.WriteLine("Roll Number : " + Roll_Number);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Branch : " + Branch);
        }
    }
    class Inheritance
    {
        public static void Main()
        {
            Student1 s1 = new Student1();
            s1.GetMentorData(552, "Rajesh Shukla", 3);
            s1.GetStudent1Data(51, "Nikunj Bopche", "CSE");
            s1.DisplayMentorData();
            s1.DisplayStudnet1Data();

            Student2 s2 = new Student2();
            s2.GetMentorData(567, "Santosh Khurana", 1);
            s2.GetStudent2Data(12, "Priya Manil", "Mechanical Engg");
            s2.DisplayMentorData();
            s2.DisplayStudnet2Data();

            Student3 s3 = new Student3();
            s3.GetMentorData(421, "Ravi Kumar", 2);
            s3.GetStudent3Data(45, "Himanshu Navghare", "Civil Engg");
            s3.DisplayMentorData();
            s3.DisplayStudnet3Data();

            Student4 s4 = new Student4();
            s4.GetMentorData(810, "Manoj Shahu", 2);
            s4.GetStudent4Data(65, "Aditya Bagle", "Electronics Engg");
            s4.DisplayMentorData();
            s4.DisplayStudnet4Data();

            Console.ReadLine();
        }
    }
}