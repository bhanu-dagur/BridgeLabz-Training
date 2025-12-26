using System;

class FootballPlayers
{
    // Method to generate random heights between 150 and 250 cm
    public static int[] GenerateHeights(int size)
    {
        int[] heights = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            heights[i] = rand.Next(150, 251); // 150 to 250 inclusive
        }

        return heights;
    }

    // Method to calculate sum of array elements
    public static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return sum;
    }

    // Method to calculate mean height
    public static double CalculateMean(int[] array)
    {
        int sum = CalculateSum(array);
        return (double)sum / array.Length;
    }

    // Method to find shortest height
    public static int FindShortest(int[] array)
    {
        int min = array[0];
        foreach (int value in array)
        {
            min = Math.Min(min, value);
        }
        return min;
    }

    // Method to find tallest height
    public static int FindTallest(int[] array)
    {
        int max = array[0];
        foreach (int value in array)
        {
            max = Math.Max(max, value);
        }
        return max;
    }

    static void Main()
    {
        int teamSize = 11;

        // Generate random heights
        int[] heights = GenerateHeights(teamSize);

        Console.WriteLine("Heights of football players (in cm):");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine();

        // Calculate statistics
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);
        double mean = CalculateMean(heights);

        // Display results
        Console.WriteLine("\nShortest height: " + shortest + " cm");
        Console.WriteLine("Tallest height: " + tallest + " cm");
        Console.WriteLine("Mean height: " + mean.ToString("F2") + " cm");
  
    }
}
