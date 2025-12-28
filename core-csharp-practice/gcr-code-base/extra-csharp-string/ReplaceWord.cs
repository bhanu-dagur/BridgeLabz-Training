using System;
class ReplaceWord
{
    static void Main()
    {
        Console.WriteLine("Enter the String");
        string str=Console.ReadLine();
        Console.WriteLine("Enter the word that replace by another word");
        string word=Console.ReadLine();
        Console.WriteLine("Enter the replace word");
        string replace=Console.ReadLine();

        string []s=str.Split(' ');
        String result=Replace(s,word,replace);
        Console.WriteLine("String after the modification :"+result);
    }
    static string Replace(string []s,string find,string replace)
    {
        string ans="";
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == find)
            {
                ans+=replace+" ";
            }
            else
            {
                ans+=s[i]+" ";
            }
        }
        return ans;
    }
}