using System;

namespace TailoringWorkshop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double areaBig = tables * (sideA + 2 * 0.30) * (sideB + 2 * 0.30);
            double areaLittle = tables * (sideA / 2) * (sideA / 2);

            double usdPrice = areaBig * 7 + areaLittle * 9;
            double bgnPrice = usdPrice * 1.85;

            Console.WriteLine($"{usdPrice:F2}" + " USD");
            Console.WriteLine($"{bgnPrice:F2}" + " BGN");
        }
    }
}