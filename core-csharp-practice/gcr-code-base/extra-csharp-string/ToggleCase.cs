using System;
class ToggleCase
{
    static void Main()
    {
        Console.WriteLine("Enter the String ");
        string s=Console.ReadLine();
        string ans="";

        for(int i = 0; i < s.Length; i++)
        {
            char ch=s[i];
            if(ch>='a' && ch <= 'z')
            {
               ans+=(char)(ch-32); 
            }
            else if(ch>='A' && ch <= 'Z')
            {
                ans+=(char)(ch+32);
            }
            else
            {
                ans+=s[i];
            }
        }
        Console.WriteLine("String afer toggle case is: "+ans);
    }
}