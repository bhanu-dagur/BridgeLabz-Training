using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0)
            return new int[0];

        LinkedList<int> deque = new LinkedList<int>(); // store indices
        int[] result = new int[nums.Length - k + 1];
        int ri = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            // Remove indices which are out of this window
            if (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            // Remove smaller elements from back
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
            {
                deque.RemoveLast();
            }

            //Add current index
            deque.AddLast(i);

            //Store max when window is ready
            if (i >= k - 1)
            {
                result[ri++] = nums[deque.First.Value];
            }
        }

        return result;
    }
    static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        int[] output = MaxSlidingWindow(arr, k);

        Console.WriteLine("Sliding Window Maximum:");
        foreach (int val in output)
        {
            Console.Write(val + " ");
        }
    }
}


