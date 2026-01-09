using System;
using System.Collections.Generic;

public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        // value -> index

        for (int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];

            if (map.ContainsKey(need))
            {
                return new int[] { map[need], i };
            }

            // store current number with index
            map[nums[i]] = i;
        }

        return new int[0]; // never reached as solution exists
    }
    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        TwoSumProblem twoSumProblem = new TwoSumProblem();
        int[] result = twoSumProblem.TwoSum(nums, target);
    }
}
