using System;

class Program
{
    static void Main(string[] args)
    {
        int seaPackages = int.Parse(Console.ReadLine());
        int mountainPackages = int.Parse(Console.ReadLine());
        int soldSeaPackages = 0;
        int soldMountainPackages = 0;
        double profit = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Stop")
            {
                break;
            }

            if (input == "sea")
            {
                if (seaPackages > 0)
                {
                    seaPackages--;
                    soldSeaPackages++;
                    profit += 680;
                }
            }
            else if (input == "mountain")
            {
                if (mountainPackages > 0)
                {
                    mountainPackages--;
                    soldMountainPackages++;
                    profit += 499;
                }
            }

            if (seaPackages == 0 && mountainPackages == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
                Console.WriteLine($"Profit: {Math.Floor(profit)} leva.");
                return;
            }
        }

        Console.WriteLine($"Profit: {Math.Floor(profit)} leva.");
    }
}
