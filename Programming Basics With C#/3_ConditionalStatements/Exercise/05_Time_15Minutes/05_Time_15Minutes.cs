using System;

namespace Time_15Minutes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            int plusMin = min + 15;

            if (plusMin <= 59)
            {
                Console.WriteLine(hour + ":" + plusMin);
            }
            else
            {
                if (hour<23)
                {
                    hour += 1;
                    plusMin = plusMin % 60;
                    if (plusMin<10)
                    {
                        Console.WriteLine(hour + $":0{plusMin}");
                    }
                    else
                    {
                        Console.WriteLine(hour + ":" + plusMin);
                    }
                }
                else
                {
                    hour += 1;
                    hour %= 24;
                    plusMin = plusMin % 60;
                    if (plusMin < 10)
                    {
                        Console.WriteLine(hour + $":0{plusMin}");
                    }
                    else
                    {
                        Console.WriteLine(hour + ":" + plusMin);
                    }
                }
            }

        }
    }
}
