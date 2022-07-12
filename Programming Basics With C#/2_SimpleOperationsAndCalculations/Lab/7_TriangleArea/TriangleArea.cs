using System;

namespace TriangleArea
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;
            Console.WriteLine("Triangle area = " + Math.Round(area, 2)); //Moje i ($"Triangle area = {area:F2}")
        }
    }
}
