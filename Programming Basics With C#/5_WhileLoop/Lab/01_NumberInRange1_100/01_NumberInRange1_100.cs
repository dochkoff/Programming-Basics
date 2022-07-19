using System;

namespace xTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number in range [1...100]: ");
            int num = int.Parse(Console.ReadLine());

            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Enter number in range [1...100]: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is {num}");
        }
    }
}