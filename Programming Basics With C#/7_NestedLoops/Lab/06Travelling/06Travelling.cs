using System;

namespace Travelling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    return;
                }
                double minBudget = double.Parse(Console.ReadLine());
                string saving = Console.ReadLine();
                double money = double.Parse(saving);

                for (double i = money; i < minBudget; i += money)
                {
                    saving = Console.ReadLine();
                    if (saving == "End")
                    {
                        return;
                    }
                    money = double.Parse(saving);
                }
                Console.WriteLine($"Going to {destination}!");
                saving = string.Empty;
            }
        }
    }
}