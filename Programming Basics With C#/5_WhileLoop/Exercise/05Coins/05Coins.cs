using System;

namespace Coins
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal sum = decimal.Parse(Console.ReadLine()) * 100;

            int counter = 0;

            while (sum > 0)
            {
                if (sum >= 200)
                {
                    sum -= 200;
                    counter++;
                }
                else if (sum >= 100)
                {
                    sum -= 100;
                    counter++;
                }
                else if (sum >= 50)
                {
                    sum -= 50;
                    counter++;
                }
                else if (sum >= 20)
                {
                    sum -= 20;
                    counter++;
                }
                else if (sum >= 10)
                {
                    sum -= 10;
                    counter++;
                }
                else if (sum >= 5)
                {
                    sum -= 5;
                    counter++;
                }
                else if (sum >= 2)
                {
                    sum -= 2;
                    counter++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
