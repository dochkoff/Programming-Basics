using System;
using System.Linq;

namespace _09_Outing
{
    class Program
    {
        static void Main(string[] args)
        {
            double fishPrice = 0.0;
            double expence = 0.0;
            double income = 0.0;
            int counterPrice = 0;
            int counterFish = 0;
            string fishName = string.Empty;

            int quota = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quota; i++)
            {
                fishName = Console.ReadLine();

                if (fishName == "Stop")
                {
                    if (income > expence)
                    {
                        Console.WriteLine($"Lyubo's profit from {counterFish} fishes is {(income - expence):F2} leva.");
                    }
                    else
                    {
                        Console.WriteLine($"Lyubo lost {(expence - income):F2} leva today.");
                    }
                    return;
                }
                double fishWeight = double.Parse(Console.ReadLine());

                for (int x = fishName.Length - 1; x >= 0; x--)
                {
                    fishPrice = fishName.Sum(ch => (int)ch); //sumira vsqka ascii stoinost na bukvite ot imeto na ribata (dobavq se v nachaloto "using System.Linq;"
                }

                fishPrice /= fishWeight;
                counterPrice++;
                if (counterPrice == 4)
                {
                    counterPrice = 1;
                }

                if (counterPrice == 1 || counterPrice == 2)
                {
                    expence += fishPrice;
                }
                else if (counterPrice == 3)
                {
                    income += fishPrice;
                }
                fishPrice = 0;
                counterFish++;
            }

            Console.WriteLine("Lyubo fulfilled the quota!");
            if (income > expence)
            {
                Console.WriteLine($"Lyubo's profit from {counterFish} fishes is {(income - expence):F2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {(expence - income):F2} leva today.");
            }
        }
    }
}

