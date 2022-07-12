using System;

namespace StadiumIncome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sectorsCount = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double stadiumIncome = stadiumCapacity * ticketPrice;
            double singleSectorIncome = stadiumIncome / sectorsCount;
            double incomeDiff = stadiumIncome - 0.75 * singleSectorIncome;
            double charitySum = incomeDiff / 8;

            Console.WriteLine($"Total income - {stadiumIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {charitySum:F2} BGN");
        }
    }
}
