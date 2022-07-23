using System;

namespace _08_NumbersInRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;

            while (num >= n)
            {
                Console.WriteLine(n);
                n = (n * 2) + 1;
            }
        }
    }
}

