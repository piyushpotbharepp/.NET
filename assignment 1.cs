//Create a class calculate having fields num1, num2 and
//methods addition, substraction, multiplication and division

using System;

namespace calc
{
    class calculate
    {
        int num1;
        int num2;
        int res;


        public void addition(int num1, int num2)
        {
            res = num1 + num2;
        }
        public void dispaddition()
        {
            Console.WriteLine("Addition =" + res);
        }


        public void sub(int num1, int num2)
        {
            res = num1 - num2;
        }
        public void dissub()
        {
            Console.WriteLine("Substraction =" + res);
        }


        public void multi(int num1, int num2)
        {
            res = num1 * num2;
        }
        public void dismulti()
        {
            Console.WriteLine("Multiplication =" + res);
        }

        public void div(int num1, int num2)
        {
            res = num1 / num2;
        }
        public void disdiv()
        {
            Console.WriteLine("Division =" + res);
        }


    }

    class @calculatee
    {
        static void Main()
        {
            calculate ope = new calculate();

            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            ope.addition(num1,num2);
            ope.dispaddition();

            ope.sub(num1, num2);
            ope.dissub();

            ope.multi(num1, num2);
            ope.dismulti();

            ope.div(num1, num2);
            ope.disdiv();




            Console.ReadLine();
        }
    }
}