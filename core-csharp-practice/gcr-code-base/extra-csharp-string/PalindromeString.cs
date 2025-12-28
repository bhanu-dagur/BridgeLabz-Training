using System;
class PalindromeString
{
    static void Main()
    {
        Console.WriteLine("Enter the string");
        string s=Console.ReadLine();

        String reverseString="";
        for(int i = s.Length - 1; i >= 0; i--)
        {
            reverseString+=s[i];
        }
        if (reverseString == s)
        {
            Console.WriteLine("Yes String is palindrome");

        }
        else
        {
            Console.WriteLine("No, String is not plaindrome");
        }
    }
}