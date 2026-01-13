using  System;
using System.Text;
class ReverseString
{
    public static void Main(string[] args)
    {
        StringBuilder str=new StringBuilder("hello");
        StringBuilder rev=new StringBuilder();
        for(int i = str.Length-1;i>=0; i--)
        {
            rev.Append(str[i]);
        }
        Console.WriteLine(rev);
    }
}