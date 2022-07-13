using System;

namespace TrekkingEquipment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int alpinists = int.Parse(Console.ReadLine());
            int karabineres = int.Parse(Console.ReadLine());
            int ropes = int.Parse(Console.ReadLine());
            int pickels = int.Parse(Console.ReadLine());

            double karabineresMoney = karabineres * 36;
            double ropesMoney = ropes * 3.6;
            double pickelsMoney = pickels * 19.8;
            double equipmentForOneAlpinist = karabineresMoney + ropesMoney + pickelsMoney;
            double totalSum = (equipmentForOneAlpinist * alpinists) * 1.2;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
