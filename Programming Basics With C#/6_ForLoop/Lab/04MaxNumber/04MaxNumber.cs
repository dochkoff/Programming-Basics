using System;

namespace MaxNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
