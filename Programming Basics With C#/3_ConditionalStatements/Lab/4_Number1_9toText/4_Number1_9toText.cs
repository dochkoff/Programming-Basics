using System;

namespace Number1_9toText
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ako polzwame samo IF na vseki red, togava vsichkite varianti shte budat provereni
            //Ako polzwame IF / IF ELSE konstrukciq, spira da proverqva sledvashite IF ELSE sled purviq TRUE

            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
