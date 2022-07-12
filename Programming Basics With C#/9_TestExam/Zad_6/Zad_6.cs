using System;

namespace Zad_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int pos3 = n % 10;
            n = n / 10;
            int pos2 = n % 10;
            n = n / 10;

            for (int x1 = 1; x1 <= pos3; x1++)
            {
                for (int x2 = 1; x2 <= pos2; x2++)
                {
                    for (int x3 = 1; x3 <= n; x3++)
                    {
                        Console.WriteLine($"{x1} * {x2} * {x3} = {x3 * x2 * x1};");
                    }
                }
            }
        }
    }
}
