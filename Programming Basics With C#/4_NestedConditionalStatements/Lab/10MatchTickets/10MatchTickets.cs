using System;

namespace MatchTickets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1. Read input

            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            // * 2.Calculate travel cost
            double percentage = 0;

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                percentage = 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                percentage = 0.6;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                percentage = 0.5;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                percentage = 0.4;
            }
            else if (peopleCount >= 50)
            {
                percentage = 0.25;
            }

            double travelCoast = percentage * budget;

            //3.Calculate remaining money after travel and tickets price

            budget = budget - travelCoast;

            double ticketsCoast = 0;

            if (category == "VIP")
            {
                ticketsCoast = 499.99;
            }
            else if (category == "Normal")
            {
                ticketsCoast = 249.99;
            }

            budget = budget - peopleCount * ticketsCoast;


            //4. Check if remainig money is enought
            if (budget >= 0)
            {
                Console.WriteLine($"Yes! You have {budget:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget):F2} leva.");
            }

        }
    }
}
