using System;

namespace CleverLily
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toysCount = 0;
            double lastSum = 0;
            double money = 0;

            for (int year = 1; year <= age; year++)
            {
                if (year % 2 == 1)
                {
                    toysCount++;
                }
                else
                {
                    lastSum += 10;
                    money += lastSum;
                    money -= 1;
                }
            }

            money += toysCount * toyPrice;

            if (money < washingMachinePrice)
            {
                Console.WriteLine($"No! {(washingMachinePrice - money):F2}");
            }
            else
            {
                Console.WriteLine($"Yes! {(money - washingMachinePrice):F2}");
            }
        }
    }
}
