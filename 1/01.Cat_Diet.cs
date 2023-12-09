using System;

class Program
{
    static void Main()
    {
        // Read input
        int fatPercentage = int.Parse(Console.ReadLine());
        int proteinPercentage = int.Parse(Console.ReadLine());
        int carbsPercentage = int.Parse(Console.ReadLine());
        int totalCalories = int.Parse(Console.ReadLine());
        int waterPercentage = int.Parse(Console.ReadLine());

        // Calculate grams of each macronutrient
        double fatGrams = (fatPercentage / 100.0) * totalCalories / 9.0;
        double proteinGrams = (proteinPercentage / 100.0) * totalCalories / 4.0;
        double carbsGrams = (carbsPercentage / 100.0) * totalCalories / 4.0;

        // Calculate total weight of food
        double totalWeight = fatGrams + proteinGrams + carbsGrams;

        // Calculate calories per gram of food
        double caloriesPerGram = totalCalories / totalWeight;

        // Calculate calories from water
        double waterCalories = (waterPercentage / 100.0) * caloriesPerGram;

        // Calculate final calories per gram
        double finalCaloriesPerGram = caloriesPerGram - waterCalories;

        // Print result
        Console.WriteLine($"{finalCaloriesPerGram:F4}");
    }
}
