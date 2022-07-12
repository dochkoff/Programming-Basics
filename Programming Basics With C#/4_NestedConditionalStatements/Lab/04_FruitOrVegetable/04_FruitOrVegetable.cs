using System;

namespace _FruitOrVegetable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string food = Console.ReadLine();

            if (food == "banana" ||
                food == "apple" ||
                food == "kiwi" ||
                food == "cherry" ||
                food == "lemon" ||
                food == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "tomato" ||
                     food == "cucumber" ||
                     food == "pepper" ||
                     food == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

            // sus switch - deistva kato mnojestvo else if proverki

            //string food = Console.ReadLine();

            //switch (food)
            //{
            //    case "apple":
            //    case "banana":
            //    case "kiwi":
            //    case "cherry":
            //    case "lemon":
            //    case "grapes":
            //        Console.WriteLine("fruit");
            //        break;
            //    case "tomato":
            //    case "cucumber":
            //    case "pepper":
            //    case "carrot":
            //        Console.WriteLine("vegetable");
            //        break;
            //    default:
            //        Console.WriteLine("unknown");
            //}
        }
    }
}
