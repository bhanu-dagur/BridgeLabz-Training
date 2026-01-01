/*
Day-> 01-01-2026
Quetions leetcode 242

Given two strings s and t, return true if t is an anagram of s, and false otherwise.
Example 1:
Input: s = "anagram", t = "nagaram"
Output: true
*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)  return false;
        int n=s.Length;
        // frequency array that count the freq of each character
        int [] freq=new int[26];
        for(int i=0;i<n;i++){
            char ch=s[i];
            freq[ch-'a']++;
        }
        for(int i=0;i<t.Length;i++){
            char ch=t[i];
            freq[ch-'a']--;
        }

        foreach(int count in freq){
            if(count!=0){
                return false;
            }
        }
        return true;
    }
}