/*
DAY-> 01-01-2026
Question leetcode 997;
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

Example 1:
Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
*/

public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n=nums.Length;
        int [] ans=new int[n];
        for (int i=0;i<nums.Length;i++){
            int item=nums[i]*nums[i];
            ans[i]=item;
        }
        Array.Sort(ans);
        return ans;
    }
}