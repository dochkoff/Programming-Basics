using System;

namespace Choreography
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minimumSelary = double.Parse(Console.ReadLine());

            double socialScholarship = 0.0;
            double excellentScholarship = 0.0;

            if (income >= minimumSelary || score <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimumSelary && score > 4.5)
            {
                socialScholarship = minimumSelary * 0.35;
                if (score >= 5.5)
                {
                    excellentScholarship = score * 25;
                    if (excellentScholarship < socialScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                    }
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
            }
        }
    }
}