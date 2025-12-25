using System;

class LargestSmallestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(n1, n2, n3);

        Console.WriteLine("Smallest Number = " + result[0]);
        Console.WriteLine("Largest Number = " + result[1]);
    }

    public static int[] FindSmallestAndLargest(int num1, int num2, int num3)
    {
        int smallNum = num1;
        int largeNum = num1;

        if (num2 < smallNum)
            smallNum = num2;
        if (num3 < smallNum)
            smallNum = num3;

        if (num2 > largeNum)
            largeNum = num2;
        if (num3 > largeNum)
            largeNum = num3;

        return new int[] { smallNum, largeNum };
    }
}
