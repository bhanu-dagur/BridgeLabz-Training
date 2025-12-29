using System;
class Palindrome
{
    static void Main()
    {
        string str=Input();
        bool ans=CheckPalindrome(str);
        DisplayResult(str,ans);

    }
    static String Input()
    {
        Console.WriteLine("enter the text");
        string s=Console.ReadLine();
        return s;
    }
    static bool CheckPalindrome(String s)
    {
        int left=0;
        int right=s.Length-1;
        while (left <= right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    static void DisplayResult(String s,bool ans)
    {
        if (ans)
        {
            Console.WriteLine("yes "+ s +" is a palindrome string");
        }
        else
        {
            Console.WriteLine("No "+ s +" is not a palindrome string");
        }
    }
}