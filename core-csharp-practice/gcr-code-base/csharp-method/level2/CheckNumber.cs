using System;

class CheckNum
{
    public static bool IsPositive(int num)
    {
        return num >= 0;
    }
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    
    // Returns 1 if num1 > num2, 0 if equal, -1 if num1 < num2
    public static int Compare(int num1, int num2)
    {
        if (num1 > num2) return 1;
        else if (num1 == num2) return 0;
        else return -1;
    }

    static void Main(string[] args)
    {
        int[] nums = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter num " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (IsPositive(nums[i]))
            {
                if (IsEven(nums[i]))
                    Console.WriteLine(nums[i] + " is Positive and Even");
                else
                    Console.WriteLine(nums[i] + " is Positive and Odd");
            }
            else
            {
                Console.WriteLine(nums[i] + " is Negative");
            }
        }

        // Compare first and last elements
        int result = Compare(nums[0], nums[4]);
        if (result == 1)
            Console.WriteLine("First element  is greater than last element " );
        else if (result == 0)
            Console.WriteLine("First element  is equal to last element ");
        else
            Console.WriteLine("First element  is less than last element ");
    }
}
