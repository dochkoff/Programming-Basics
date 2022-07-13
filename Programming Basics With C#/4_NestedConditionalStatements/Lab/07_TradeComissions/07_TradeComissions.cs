using System;

namespace TradeComissions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine());

            double commision = -1;

            if (sells >= 0 && sells <= 500)
            {
                if (city == "sofia")
                {
                    commision = sells * 0.05;
                }
                else if (city == "varna")
                {
                    commision = sells * 0.045;
                }
                else if (city == "plovdiv")
                {
                    commision = sells * 0.055;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sells > 500 && sells <= 1000)
            {
                if (city == "sofia")
                {
                    commision = sells * 0.07;
                }
                else if (city == "varna")
                {
                    commision = sells * 0.075;
                }
                else if (city == "plovdiv")
                {
                    commision = sells * 0.08;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sells > 1000 && sells <= 10000)
            {
                if (city == "sofia")
                {
                    commision = sells * 0.08;
                }
                else if (city == "varna")
                {
                    commision = sells * 0.1;
                }
                else if (city == "plovdiv")
                {
                    commision = sells * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sells > 10000)
            {
                if (city == "sofia")
                {
                    commision = sells * 0.12;
                }
                else if (city == "varna")
                {
                    commision = sells * 0.13;
                }
                else if (city == "plovdiv")
                {
                    commision = sells * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (commision != -1)
            {
                Console.WriteLine($"{commision:F2}");
            }
        }
    }
}
