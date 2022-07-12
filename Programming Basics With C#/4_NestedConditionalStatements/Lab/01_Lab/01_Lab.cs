using System;

namespace _Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string shopType = Console.ReadLine();
            int eggsNeeded = int.Parse(Console.ReadLine());
            int eggsInStock = int.Parse(Console.ReadLine());

            if (shopType == "food")
            {
                if (eggsInStock > 0 && eggsInStock > eggsNeeded)
                {
                    Console.WriteLine("eggs bought");
                }
                else
                {
                    Console.WriteLine("no eggs or not enought");
                }
            }
            else
            {
                Console.WriteLine("try another shop");
            }
        }
    }
}
