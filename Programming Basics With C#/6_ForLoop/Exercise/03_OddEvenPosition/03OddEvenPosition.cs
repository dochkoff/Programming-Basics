using System;

namespace OddEvenPosition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestOdd = -1000000000.0;
            double biggestEven = -1000000000.0;
            double smallestOdd = 1000000000.0;
            double smallestEven = 1000000000.0;
            double sumOdd = 0;
            double sumEven = 0;
            double number = 0;

            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (number > biggestOdd)
                    {
                        biggestOdd = number;
                    }

                    if (number < smallestOdd)
                    {
                        smallestOdd = number;
                    }

                    sumOdd += number;
                }
                else
                {
                    if (number > biggestEven)
                    {
                        biggestEven = number;
                    }

                    if (number < smallestEven)
                    {
                        smallestEven = number;
                    }

                    sumEven += number;
                }
            }

            if (n == 0)
            {
                Console.WriteLine($"OddSum=0");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum={number}");
                Console.WriteLine($"OddMin={number}");
                Console.WriteLine($"OddMax={number}");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={sumOdd}");
                Console.WriteLine($"OddMin={smallestOdd}");
                Console.WriteLine($"OddMax={biggestOdd}");
                Console.WriteLine($"EvenSum={sumEven}");
                Console.WriteLine($"EvenMin={smallestEven}");
                Console.WriteLine($"EvenMax={biggestEven}");
            }
        }
    }
}