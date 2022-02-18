//3 - create a class student having fields rno, name, mathsmarks, chemmarks, phymarks,
// total, per, grade and method result to calculate and display total, per and grade

using System;
namespace student
{
    class student
    {
        int rno;
        string name;
        int math;
        int chem;
        int phy;
        int total;
        float per;
        string grade;

        public void totall(int math, int chem, int phy)
        {
            total = math + chem + phy;
        }
        public void disptotal()
        {
            Console.WriteLine("Total Marks=" + total);
        }


        public void percentage(int math, int chem, int phy)
        {
            per = (math + chem + phy) * 100 / 300;
        }
        public void dispper()
        {
            Console.WriteLine("Percentage=" + per);
        }

        public void gradee(int math, int chem, int phy)
        {
            per = (math + chem + phy) * 100 / 300;
        }
        public void dispgrade()
        {
            if (per > 80)
            {
                Console.WriteLine("A");
            }
            else if (per > 60 && per < 79)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }
        }
    }
    class @studentt
    {
        static void Main()
        {
            student stu = new student();

            Console.WriteLine("enter your Roll No");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Maths Marks");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry Marks");
            int chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter physics Marks");
            int phy = Convert.ToInt32(Console.ReadLine());

            stu.totall(math, chem, phy);
            stu.disptotal();
            stu.percentage(math, chem, phy);
            stu.dispper();
            stu.gradee(math, chem, phy);
            stu.dispgrade();

            Console.ReadLine();


        }
    }

}