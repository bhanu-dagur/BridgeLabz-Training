//  25-12-2025
// Two Sum leetcode problem  01
public class TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] arr = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {
                    arr[0] = i;
                    arr[1] = j;
                }
            }
        }
        return arr;
    }
}
