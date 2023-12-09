using System;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = double.Parse(Console.ReadLine());
            var service = Console.ReadLine();
            var distance = int.Parse(Console.ReadLine());

            var pricePerKilometer = 0.0;
            var coststandard = 0.0;
            var costexpress = 0.0;
            var up = 0.0;
            var up2 = 0.0;
            var up3 = 0.0;

            if (service == "standard")
            {
                if (weight < 1)
                {
                    pricePerKilometer = 0.03;
                    coststandard = distance * pricePerKilometer;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {coststandard:f2} lv.");
                }
                else if (weight >= 1 && weight <= 10)
                {
                    pricePerKilometer = 0.05;
                    coststandard = distance * pricePerKilometer;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {coststandard:f2} lv.");
                }
                else if (weight >= 11 && weight <= 40)
                {
                    pricePerKilometer = 0.10;
                    coststandard = distance * pricePerKilometer;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {coststandard:f2} lv.");
                }
                else if (weight >= 41 && weight <= 90)
                {
                    pricePerKilometer = 0.15;
                    coststandard = distance * pricePerKilometer;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {coststandard:f2} lv.");
                }
                else if (weight >= 91 && weight <= 150)
                {
                    pricePerKilometer = 0.20;
                    coststandard = distance * pricePerKilometer;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {coststandard:f2} lv.");
                }
            }
            else if (service == "express")
            {
                if (weight < 1)
                {
                    pricePerKilometer = 0.03;
                    coststandard = distance * pricePerKilometer;
                    up = 0.80 * pricePerKilometer;
                    up2 = distance * up;
                    up3 = weight * up2;
                    costexpress = coststandard + up3;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {costexpress:f2} lv.");
                }
                else if (weight >= 1 && weight <= 10)
                {
                    pricePerKilometer = 0.05;
                    coststandard = distance * pricePerKilometer;
                    up = 0.40 * pricePerKilometer;
                    up2 = distance * up;
                    up3 = weight * up2;
                    costexpress = coststandard + up3;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {costexpress:f2} lv.");
                }
                else if (weight >= 11 && weight <= 40)
                {
                    pricePerKilometer = 0.10;
                    coststandard = distance * pricePerKilometer;
                    up = 0.05 * pricePerKilometer;
                    up2 = distance * up;
                    up3 = weight * up2;
                    costexpress = coststandard + up3;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {costexpress:f2} lv.");
                }
                else if (weight >= 41 && weight <= 90)
                {
                    pricePerKilometer = 0.15;
                    coststandard = distance * pricePerKilometer;
                    up = 0.02 * pricePerKilometer;
                    up2 = distance * up;
                    up3 = weight * up2;
                    costexpress = coststandard + up3;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {costexpress:f2} lv.");
                }
                else if (weight >= 91 && weight <= 150)
                {
                    pricePerKilometer = 0.20;
                    coststandard = distance * pricePerKilometer;
                    up = 0.01 * pricePerKilometer;
                    up2 = distance * up;
                    up3 = weight * up2;
                    costexpress = coststandard + up3;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {costexpress:f2} lv.");
                }
            }
        }
    }
}
