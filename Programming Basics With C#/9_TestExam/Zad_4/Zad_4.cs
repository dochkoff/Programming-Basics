using System;

namespace Zad_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double expences = 0;
            double balloons = 0;
            double flowers = 0;
            double candles = 0;
            double ribbon = 0;

            while (budget - expences > 0)
            {
                string stockType = Console.ReadLine();

                if (stockType == "stop")
                {
                    Console.WriteLine($"Spend money: {expences:F2}");
                    Console.WriteLine($"Money left: {(budget - expences):F2}");
                    Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
                    return;
                }

                double count = double.Parse(Console.ReadLine());
                switch (stockType)
                {
                    case "balloons":
                        expences += count * 0.1;
                        balloons += count;
                        break;
                    case "flowers":
                        expences += count * 1.5;
                        flowers += count;
                        break;
                    case "candles":
                        expences += count * 0.5;
                        candles += count;
                        break;
                    case "ribbon":
                        expences += count * 2;
                        ribbon += count;
                        break;
                }
            }

            Console.WriteLine("All money is spent!");
            Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
        }
    }
}
