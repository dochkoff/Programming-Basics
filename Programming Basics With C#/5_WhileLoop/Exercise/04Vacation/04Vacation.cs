using System;

namespace Vacation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int holydayMoney = int.Parse(Console.ReadLine());
            int savings = int.Parse(Console.ReadLine());

            int spendDays = 0;
            int dayes = 0;

            while (savings < holydayMoney)
            {
                string input = Console.ReadLine();
                int money = int.Parse(Console.ReadLine());

                if (input == "save")
                {
                    savings += money;
                    spendDays = 0;
                    dayes++;
                }

                if (input == "spend")
                {
                    if (savings >= money)
                    {
                        savings -= money;
                    }
                    else
                    {
                        savings = 0;
                    }
                    dayes++;
                    spendDays++;
                }

                if (spendDays == 5)
                {
                    break;
                }
            }

            if (savings >= holydayMoney)
            {
                Console.WriteLine($"You saved the money for {dayes} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayes);
            }
        }
    }
}