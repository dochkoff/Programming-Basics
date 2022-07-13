using System;

namespace BonusScore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var bonus = int.Parse(Console.ReadLine());

            double points = 0.0;

            if (bonus <= 100)
            {
                points = 5;
            }
            else if (bonus > 100)
            {
                if (bonus > 1000)
                {
                    points = bonus * 0.1;
                }
                else
                {
                    points = bonus * 0.2;
                }
            }
                
            if (bonus % 2 == 0)
            {
                points += 1;
            }
            else if (bonus % 10 == 5)
            {
                points += 2;
            }

            Console.WriteLine(points);
            Console.WriteLine(bonus + points);
        }
    }
}
