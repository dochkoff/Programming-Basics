using System;

namespace NewHouse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //              цвете Роза    Далия    Лале  Нарцис Гладиола
            //Цена на брой в лева   5      3.80    2.80    3      2.50

            //Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double neededMoney = 0;
            double leftMoney = 0;

            if (flowersType == "Roses")
            {
                if (flowersCount <= 80)
                {
                    neededMoney = flowersCount * 5;
                }
                else
                {
                    neededMoney = (flowersCount * 5) * 0.9;
                }
            }
            else if (flowersType == "Dahlias")
            {
                if (flowersCount <= 90)
                {
                    neededMoney = flowersCount * 3.8;
                }
                else
                {
                    neededMoney = (flowersCount * 3.8) * 0.85;
                }
            }
            else if (flowersType == "Tulips")
            {
                if (flowersCount <= 80)
                {
                    neededMoney = flowersCount * 2.8;
                }
                else
                {
                    neededMoney = (flowersCount * 2.8) * 0.85;
                }
            }
            else if (flowersType == "Narcissus")
            {
                if (flowersCount >= 120)
                {
                    neededMoney = flowersCount * 3;
                }
                else
                {
                    neededMoney = (flowersCount * 3) * 1.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                if (flowersCount >= 80)
                {
                    neededMoney = flowersCount * 2.5;
                }
                else
                {
                    neededMoney = (flowersCount * 2.5) * 1.2;
                }
            }

            leftMoney = budget - neededMoney;
            if (leftMoney >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {leftMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(leftMoney):F2} leva more.");
            }
        }
    }
}
