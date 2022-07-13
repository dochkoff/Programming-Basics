using System;

namespace Journey
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string destination = string.Empty;
            int moneyNeeded = 0;
            int savings = 0;
            int money = 0;

            while (true)
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                moneyNeeded = int.Parse(Console.ReadLine());
                savings = 0;
                money = 0;
                while (money < moneyNeeded)
                {
                    savings = int.Parse(Console.ReadLine());
                    money += savings;
                    if (money >= moneyNeeded)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }
                }
            }
        }
    }
}
