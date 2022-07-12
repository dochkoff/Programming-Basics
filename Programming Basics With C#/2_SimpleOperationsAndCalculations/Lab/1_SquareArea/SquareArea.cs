using System;

namespace SquareArea
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int/int = int dori i promenlivata da e double (vrushta cqlo chislo)(25/4=6)
            //no ako napishem 25/4.0=6.25
            //nikoga ne se deli na 0
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine(area);
        }
    }
}
