using System;

namespace Exercise06CharityCampaign
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int wafreta = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());

            double cakeSum = cake * 45;
            double wafretaSum = wafreta * 5.80;
            double pancakeSum = pancake * 3.20;

            double daySum = (cakeSum + wafretaSum + pancakeSum) * confectioners;
            double allDaysSum = days * daySum;
            double donation = allDaysSum - (allDaysSum / 8);

            Console.WriteLine($"{donation:F2}");
        }
    }
}
