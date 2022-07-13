using System;

namespace MaxNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
