using System;

namespace RectangleArea
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);
            double s = sideA * sideB;
            double p = 2 * (sideA + sideB);

            Console.WriteLine(s);
            Console.WriteLine(p);
        }
    }
}
