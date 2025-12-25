using System;

class FindYoungestFriend
{
    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] height = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + " (in cm): ");
            height[i] = double.Parse(Console.ReadLine());
        }

        string youngest = FindYoungest(ages, names);
        string tallest = FindTallest(height, names);

        Console.WriteLine("The youngest friend is " + youngest);
        Console.WriteLine("The tallest friend is " + tallest);
    }
        // Method to find the youngest friend
    public static string FindYoungest(int[] ages, string[] names)
    {
        int minAge = ages[0];
        string youngest = names[0];

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                youngest = names[i];
            }
        }
        return youngest;
    }

    // Method to find the tallest friend
    public static string FindTallest(double[] height, string[] names)
    {
        double maxHeight = height[0];
        string tallest = names[0];

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i] > maxHeight)
            {
                maxHeight = height[i];
                tallest = names[i];
            }
        }
        return tallest;
    }
}
