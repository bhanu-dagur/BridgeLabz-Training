using System;
class ParaGraphFormatter
{
    static void Main()
    {
        Console.WriteLine("Enter the paragraph");
        string para=Console.ReadLine();
        int words=NumberOfWords(para);
        Console.WriteLine("Number of word in the paragraph is: "+words);
        string result=LongestWord(para);
        Console.WriteLine("Longest word in the paragraph is :"+result);
        result=Replace(para);
        Console.WriteLine("Paragrapg after the replaceing: "+ result);

    }
    static int NumberOfWords(string s)
    {
        string [] arr=s.Trim().Split(' ');
        int count=0;
        for(int i = 0; i < arr.Length; i++)
        {
            count++;
        }
        return count;
    }
    static string LongestWord(string s)
    {
        string [] arr=s.Split(' ');
        int maxWord=0;
        string ans=" ";
        for(int i = 0; i < arr.Length; i++)
        {
            if (maxWord < arr[i].Length)
            {
                maxWord=arr[i].Length;
                ans=arr[i];
            }
        }
        return ans;
    }
    static string Replace(String s)
    {
        Console.WriteLine("enter the word that you want to replace");
        string word=Console.ReadLine();
        Console.WriteLine("enter the replace word");
        string replace=Console.ReadLine();
        string [] arr=s.Split(' ');
        string ans=" ";
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i]==word)
            {
                ans+=replace+" ";
            }
            else
            {
                ans+=arr[i]+" ";
            }
        }
        return ans;
    }
}