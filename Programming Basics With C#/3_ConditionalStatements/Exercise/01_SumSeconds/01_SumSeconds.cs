using System;

namespace SumSeconds
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int allTime = time1 + time2 + time3;
            int minutes = allTime / 60;
            int secounds = allTime % 60;

            if (secounds<10)
            {
                Console.WriteLine($"{minutes}:0{secounds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secounds}");
            }
        }
    }
}
