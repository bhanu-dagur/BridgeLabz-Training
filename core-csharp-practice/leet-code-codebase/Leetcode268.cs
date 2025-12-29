/*
Date-> 29/12/2025
Question: Missing Number
Given an array nums containing n distinct numbers in the range [0, n], 
return the only number in the range that is missing from the array.

*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit=int.MinValue;
        int buy=prices[0];
        for(int i=0;i<prices.Length;i++){
            maxProfit=Math.Max(maxProfit,prices[i]-buy);
            buy=Math.Min(buy,prices[i]);
        }
        return maxProfit;
    }
}