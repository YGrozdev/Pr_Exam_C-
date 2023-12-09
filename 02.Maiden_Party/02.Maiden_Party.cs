using System;

namespace WeddingShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int loveMessages = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keyholders = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int surprises = int.Parse(Console.ReadLine());

            double loveMessagesPrice = loveMessages * 0.60;
            double waxRosesPrice = waxRoses * 7.20;
            double keyholdersPrice = keyholders * 3.60;
            double caricaturesPrice = caricatures * 18.20;
            double surprisesPrice = surprises * 22.00;

            double total = loveMessagesPrice + waxRosesPrice + keyholdersPrice + caricaturesPrice + surprisesPrice;

            int totalItems = loveMessages + waxRoses + keyholders + caricatures + surprises;

            if (totalItems >= 25)
            {
                total *= 0.65; // 35% discount
            }

            double hostingFee = total * 0.10;
            double profit = total - hostingFee;

            if (profit >= budget)
            {
                double remainingMoney = profit - budget;
                Console.WriteLine($"Yes! {remainingMoney:f2} lv left.");
            }
            else
            {
                double neededMoney = budget - profit;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}
