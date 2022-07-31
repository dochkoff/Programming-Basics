using System;

namespace _07_SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;
            int trigerPrime = 0;

            while (command != "stop")
            {
                int n = int.Parse(command);

                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (n == 0 || n == 1)
                {
                    sumNonPrime += n;
                    trigerPrime++;
                }

                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        sumNonPrime += n;
                        trigerPrime++;
                        break;
                    }
                }

                if (n > 1 && trigerPrime == 0)
                {
                    sumPrime += n;
                }

                trigerPrime = 0;
                command = Console.ReadLine();
            }

            if (command == "stop")
            {
                Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
                Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
            }
        }
    }
}
