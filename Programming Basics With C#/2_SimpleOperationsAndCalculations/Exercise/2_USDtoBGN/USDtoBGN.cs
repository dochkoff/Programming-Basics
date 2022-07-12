using System;

namespace USDtoBGN
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549;
            double usdToBGN = usd * bgn;

            Console.WriteLine(Math.Round(usdToBGN, 2));
        }
    }
}
