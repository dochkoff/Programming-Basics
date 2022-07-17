using System;

namespace Journey
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget * 0.3:F2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget * 0.7:F2}");
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget * 0.4:F2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget * 0.8:F2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget * 0.9:F2}");
            }
        }
    }
}