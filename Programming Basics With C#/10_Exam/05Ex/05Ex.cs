using System;

namespace Ex
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 0; i < groups; i++)
            {
                int menInGroup = int.Parse(Console.ReadLine());

                if (menInGroup <= 5)
                {
                    musala += menInGroup;
                }
                else if (menInGroup >= 6 && menInGroup <= 12)
                {
                    monblan += menInGroup;
                }
                else if (menInGroup >= 13 && menInGroup <= 25)
                {
                    kilimandjaro += menInGroup;
                }
                else if (menInGroup >= 26 && menInGroup <= 40)
                {
                    k2 += menInGroup;
                }
                else if (menInGroup >= 41)
                {
                    everest += menInGroup;
                }
            }

            double allMen = musala + monblan + kilimandjaro + k2 + everest;

            double percentForMusala = musala / allMen * 100;
            double percentForMonblan = monblan / allMen * 100;
            double percentForKilimandjaro = kilimandjaro / allMen * 100;
            double percentForK2 = k2 / allMen * 100;
            double percentForEverest = everest / allMen * 100;

            Console.WriteLine($"{percentForMusala:F2}%");
            Console.WriteLine($"{percentForMonblan:F2}%");
            Console.WriteLine($"{percentForKilimandjaro:F2}%");
            Console.WriteLine($"{percentForK2:F2}%");
            Console.WriteLine($"{percentForEverest:F2}%");

        }
    }
}
