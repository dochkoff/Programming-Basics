using System;

namespace GreatestCommonDivisor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int t = 0;

            while (b != 0)
            {
                t = b; //1
                b = a % b; //1
                a = t; //3

                if (a == b)
                {
                    Console.WriteLine(a);
                    break;
                }
            }
            Console.WriteLine(t);
        }
    }
}
