using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        HashSet<int> set = new HashSet<int>();

        // Step 1: store all elements
        foreach (int num in nums)
        {
            set.Add(num);
        }

        int longest = 0;

        // Step 2: find longest sequence
        foreach (int num in nums)
        {
            // check if num is start of sequence
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int count = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    count++;
                }

                longest = Math.Max(longest, count);
            }
        }

        return longest;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine(LongestConsecutive(arr));
    }
}
