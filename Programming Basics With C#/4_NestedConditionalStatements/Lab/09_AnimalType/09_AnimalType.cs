using System;

namespace _AnimalType
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }

            //switch (animal)
            //{
            //    default: Console.WriteLine("unknown");
            //        break;
            //    case "dog":
            //        Console.WriteLine("mammal");
            //        break;
            //    case "crocodile" || "tortoise" || "snake":
            //        Console.WriteLine("reptile");
            //        break;
            //}
        }
    }
}
