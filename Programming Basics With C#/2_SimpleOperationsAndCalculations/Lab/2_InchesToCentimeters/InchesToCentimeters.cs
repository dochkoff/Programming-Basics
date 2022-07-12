using System;

namespace InchesToCentimeters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double sm = inches * 2.54;
            Console.WriteLine(sm);
        }
    }
}
