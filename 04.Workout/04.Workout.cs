using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double sum = M;

            for (int i = 0; i < n; i++)
            {
                int K = int.Parse(Console.ReadLine());
                M *= 1 + K / 100.0;
                sum += M;
            }
            if (sum <= 1000.00)
            {
                Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0} more kilometers", Math.Ceiling(1000.00 - sum));
            }
            else
            {
                Console.WriteLine("You've done a great job running {0} more kilometers! ", Math.Ceiling(sum - 1000.00));
            }
        }
    }
}