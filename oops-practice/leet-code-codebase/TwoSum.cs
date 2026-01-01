/*
DAY-> 01-01-2026
Question-> LeetCode 1
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n=nums.Length;
        int [] ans=new int[2];
        for(int i=0;i<n;i++){
            int sum=nums[i];
            for(int j=i+1;j<n;j++){
                sum+=nums[j];
                if(sum==target){
                    ans[0]=i;
                    ans[1]=j;
                    break;
                }
                
            }
        }
        return ans;
    }
}