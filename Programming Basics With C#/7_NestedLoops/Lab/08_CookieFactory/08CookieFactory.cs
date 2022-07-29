using System;

namespace CookieFactory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int lots = int.Parse(Console.ReadLine());
            string product = string.Empty;

            for (int i = 1; i <= lots; i++)
            {
                product = Console.ReadLine();

                bool flour = false;
                bool eggs = false;
                bool sugar = false;

                while (true)
                {
                    switch (product)
                    {
                        case "flour":
                            flour = true;
                            break;
                        case "eggs":
                            eggs = true;
                            break;
                        case "sugar":
                            sugar = true;
                            break;
                    }

                    if (product == "Bake!")
                    {
                        if (eggs && sugar && flour == true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    }
                    product = Console.ReadLine();
                }
            }
        }
    }
}