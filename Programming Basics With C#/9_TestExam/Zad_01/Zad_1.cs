using System;

namespace Zad_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double soyveniresMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double travelMoney = (4.2 * 7) * 1.85;
            double expencesMooney = 3 * foodMoney + 3 * soyveniresMoney;
            double allDayHotelMoney = hotelMoney * 0.9 + hotelMoney * 0.85 + hotelMoney * 0.8;

            Console.WriteLine($"Money needed: {(travelMoney + expencesMooney + allDayHotelMoney):F2}");
        }
    }
}
