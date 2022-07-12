using System;

namespace Salary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int selary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string siteName = Console.ReadLine();

                if (siteName == "Facebook")
                {
                    selary -= 150;
                }

                if (siteName == "Instagram")
                {
                    selary -= 100;
                }

                if (siteName == "Reddit")
                {
                    selary -= 50;
                }

                if (selary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(selary);
        }
    }
}
