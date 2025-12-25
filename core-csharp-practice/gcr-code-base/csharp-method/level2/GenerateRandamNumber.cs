using System;

class GenerateRandamNumber
{
    // Method to generate array of 4-digit random numbers
    public static int[] GenerateRandomArray(int size)
    {
        int[] numbers = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            // Generate random number between 1000 and 9999
            numbers[i] = rand.Next(1000, 10000);
        }

        return numbers;
    }

    // Method to find average, min, and max
    public static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        double sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }

    static void Main()
    {
        int size = 5;

        // Generate random numbers
        int[] randomNumbers = GenerateRandomArray(size);

        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int num in randomNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Find average, min, max
        double[] stats = FindAverageMinMax(randomNumbers);
        Console.WriteLine("Average: " + stats[0]);
        Console.WriteLine("Minimum: " + stats[1]);
        Console.WriteLine("Maximum: " + stats[2]);
    }
}
