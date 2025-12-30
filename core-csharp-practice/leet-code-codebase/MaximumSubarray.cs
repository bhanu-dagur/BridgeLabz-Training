/* 
Date->30-12-2025
Question leetcode 53 (Maximum Subarray)

Given an integer array nums, find the subarray with the largest sum, and return its sum.

Example 1:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.

Example 2:
Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1. */
  
public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum=0;
        int max=int.MinValue;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
            max=Math.Max(max,sum);
            if(sum<0){
                sum=0;
            }
        }
        return max;
    }
}