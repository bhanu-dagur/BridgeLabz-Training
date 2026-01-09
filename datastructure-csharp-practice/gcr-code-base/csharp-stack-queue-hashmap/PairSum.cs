using System;
using System.Collections.Generic;

class PairWithSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in arr)
        {
            int needed = target - num;

            if (set.Contains(needed))
            {
                return true; 
            }

            set.Add(num);
        }

        return false;
    }

    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        Console.WriteLine(HasPairWithSum(arr, target));
    }
}
