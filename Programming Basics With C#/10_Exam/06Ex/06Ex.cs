using System;

namespace Ex
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 2; b <= 30; b++)
                {
                    for (int c = 30; c > 0; c--)
                    {
                        if (a < b && b < c && a + b + c == key)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {key}");
                            counter++;
                        }

                        if (a > b && b > c && a * b * c == key)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {key}");
                            counter++;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
