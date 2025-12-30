/* 
Day ->30-12-2025
Question leetcode 125 (Valid Palindrome);
125. Valid Palindrome

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
and removing all non-alphanumeric characters, it reads the same forward and backward.
Alphanumeric characters include letters and numbers.
Given a string s, return true if it is a palindrome, or false otherwise.

Example 1:
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:
Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome
*/
public class Solution {
    public bool IsPalindrome(string s) {

        string ans = "";

        for (int i = 0; i < s.Length; i++) {
            char ch = s[i];

            if (char.IsLetterOrDigit(ch)) {
                ans += char.ToLower(ch);
            }
        }

        int left = 0;
        int right = ans.Length - 1;

        while (left < right) {
            if (ans[left] != ans[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
