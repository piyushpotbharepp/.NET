//2- create a class cirlce having fields radius and
//method calculatearea and calculatecirc

using System;

namespace circle
{
    class circle
    {
        float radius;
        float area;
        float circ;


        public void areaa(float radius)
        {
            area = 3.14f * radius * radius;
        }
        public void dispareaa()
        {
            Console.WriteLine("Area Of Circle =" + area);
        }
        public void circc(float radius)
        {
            circ = 2 * 3.14f * radius;
        }
        public void dispcircc()
        {
            Console.WriteLine("Circumference Of Circle =" + circ);
        }
    }

    class @circlee
    {
        static void Main()
        {
            circle cir = new circle();
            Console.WriteLine("Enter Radius");
            float radius = Convert.ToSingle(Console.ReadLine());
            cir.areaa( radius);
            cir.dispareaa();
            cir.circc( radius);
            cir.dispcircc();

            Console.ReadLine();


        }
    }


}