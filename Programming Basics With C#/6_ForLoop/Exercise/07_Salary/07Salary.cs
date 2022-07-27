using System;

namespace Salary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string siteName = Console.ReadLine();

                if (siteName == "Facebook")
                {
                    salary -= 150;
                }

                if (siteName == "Instagram")
                {
                    salary -= 100;
                }

                if (siteName == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            }
        }
    }
}
