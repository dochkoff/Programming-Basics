using System;

namespace CurrencyConverter
{
    class MainClass
    {
        public static void Main()
        {
            var bgnUSD = 1.79549M;
            var bgnEUR = 1.95583M;
            var bgnGBP = 2.53405M;

            var usdEUR = bgnUSD / bgnEUR;
            var usdGBP = bgnUSD / bgnGBP;

            var eurGBP = bgnEUR / bgnGBP;
            var eurUSD = bgnEUR / bgnUSD;

            var gbpUSD = bgnGBP / bgnUSD;
            var gbpEUR = bgnGBP / bgnEUR;



            var amount = decimal.Parse(Console.ReadLine());
            var firstCurrency = Console.ReadLine();
            var secondCurrency = Console.ReadLine();
            var result = 0.0M;
            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "USD")
                {
                    result = amount / bgnUSD;
                }
                if (secondCurrency == "EUR")
                {
                    result = amount / bgnEUR;
                }
                if (secondCurrency == "GBP")
                {
                    result = amount / bgnGBP;
                }
            }
            if (firstCurrency == "USD")
            {
                if (secondCurrency == "BGN")
                {
                    result = amount * bgnUSD;
                }
                if (secondCurrency == "EUR")
                {
                    result = amount * usdEUR;
                }
                if (secondCurrency == "GBP")
                {
                    result = amount * usdGBP;
                }
            }
            if (firstCurrency == "EUR")
            {
                if (secondCurrency == "BGN")
                {
                    result = amount * bgnEUR;
                }
                if (secondCurrency == "USD")
                {
                    result = amount * eurUSD;
                }
                if (secondCurrency == "GBP")
                {
                    result = amount * eurGBP;
                }
            }
            if (firstCurrency == "GBP")
            {
                if (secondCurrency == "BGN")
                {
                    result = amount * bgnGBP;
                }
                if (secondCurrency == "USD")
                {
                    result = amount * gbpUSD;
                }
                if (secondCurrency == "EUR")
                {
                    result = amount * gbpEUR;
                }
            }
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}