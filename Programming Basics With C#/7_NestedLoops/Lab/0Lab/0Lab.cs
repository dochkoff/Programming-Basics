using System;

namespace Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 2 || i == 3)
                {
                    continue; // tova kazva produlji kum sledvashtata interaciq t.e. ne pechatame nishto, a otivame na i++
                }
                Console.Write(i + " ");
            }
        }
    }
}
