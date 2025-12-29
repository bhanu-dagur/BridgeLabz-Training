/*Date->28/12/2024
QUESTION: 1480. Running Sum of 1d Array
Example 1:

Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
Example 2:

Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
Example 3:

Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]    */
public class Solution {
    public int[] RunningSum(int[] nums) {
        int currentSum=0;
        int [] ans=new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            currentSum+=nums[i];
            ans[i]=currentSum;
        }
        return ans;
    }
}