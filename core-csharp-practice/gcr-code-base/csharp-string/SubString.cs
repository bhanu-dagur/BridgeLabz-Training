using System;
class SubString
{
    static void Main()
    {
        Console.WriteLine("enter the String");
        string s=Console.ReadLine();
        Console.WriteLine("enter the starting index");
        int start=int.Parse(Console.ReadLine());
        Console.WriteLine("enter the length index of subString");
        int last=int.Parse(Console.ReadLine());

        int length=last-start+1;

        String ans=GenerateSubString(s,start,length);

        if (ans.Equals(s.Substring(start, length)))
        {
            Console.WriteLine("Both subString ("+ ans+") are equal");
        }
        else
            Console.WriteLine("Both subString are not equal");
    }
    static string GenerateSubString(string s,int start,int length)
    {
        String result="";
        for(int i = start; i <= length; i++)
        {
            result+=s[i];
        }
        return result;
    }
}