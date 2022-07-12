using System;

namespace Exercise07AlcoholMarket
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double litresBeer = double.Parse(Console.ReadLine());
            double litresWine = double.Parse(Console.ReadLine());
            double litresRakia = double.Parse(Console.ReadLine());
            double litresWhiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWhiskey / 2;
            double priceWine = priceRakia * 0.6;
            double priceBeer = priceRakia * 0.2;

            double price = priceWhiskey * litresWhiskey + priceBeer * litresBeer + priceWine * litresWine + priceRakia * litresRakia;

            Console.WriteLine($"{price:F2}");
        }
    }
}
