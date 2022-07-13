using System;

namespace BeerAndChips
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double beerCost = beerCount * 1.2;
            double singleChipsCost = beerCost * 0.45;
            double chipsCost = Math.Ceiling(singleChipsCost * chipsCount);

            double sum = beerCost + chipsCost;

            if (sum <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - sum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(sum - budget):F2} more leva!");
            }

        }
    }
}
