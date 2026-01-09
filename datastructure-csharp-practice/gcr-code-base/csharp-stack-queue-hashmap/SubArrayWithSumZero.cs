using System;
using System.Collections.Generic;

class SubArrayWithSumZero
{
    public static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            // Case 1: sum becomes zero
            if (sum == 0)
            {
                Console.WriteLine("Subarray found from index 0 to " + i);
            }

            // Case 2: sum already exists
            if (map.ContainsKey(sum))
            {
                foreach (int startIndex in map[sum])
                {
                    Console.WriteLine("Subarray found from index " 
                                      + (startIndex + 1) + " to " + i);
                }
            }

            // Store sum in map
            if (!map.ContainsKey(sum))
            {
                map[sum] = new List<int>();
            }
            map[sum].Add(i);
        }
    }

    static void Main()
    {
        int[] arr = { 3, 4, -7, 1, 3, 3, 1, -4 };
        FindZeroSumSubarrays(arr);
    }
}
