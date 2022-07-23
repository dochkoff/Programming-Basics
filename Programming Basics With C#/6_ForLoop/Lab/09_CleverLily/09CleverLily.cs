using System;

namespace CleverLily
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingmachinePrice = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int counterOddBD = 0;
            int counterEvenBD = 0;
            int savedSum = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    counterEvenBD++;
                    savedSum += counterEvenBD * 10 - 1;
                }
                else
                {
                    counterOddBD++;
                }
            }

            int sumFromToys = counterOddBD * pricePerToy;
            savedSum += sumFromToys;

            if (savedSum >= washingmachinePrice)
            {
                Console.WriteLine($"Yes! {savedSum - washingmachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingmachinePrice - savedSum:F2}");
            }
        }
    }
}
