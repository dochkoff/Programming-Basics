using System;

namespace ToyShop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int countPuzzles = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countBears = int.Parse(Console.ReadLine());
            int countMinios = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double sum = countPuzzles * 2.60 + countDolls * 3 + countBears * 4.10 + countMinios * 8.20 + countTrucks * 2;
            int totalToys = countPuzzles + countDolls + countBears + countMinios + countTrucks;

            if (totalToys >= 50)
            {
                sum *= 0.75;
            }

            double rent = 0.10 * sum;
            sum = sum - rent;

            if (sum >= priceTrip)
            {
                double leftMoney = sum - priceTrip;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double needMoney = priceTrip - sum;
                Console.WriteLine($"Not enough money! {needMoney:F2} lv needed.");
            }
        }
    }
}