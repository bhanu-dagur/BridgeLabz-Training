using System;
class IndexOutOfRange
{
    static void Main()
    {
        string s="bhanu dagur";
        CheckIndexException(s);
    }
    static void CheckIndexException(string s)
    {
        try
        {
            char ch=s[11];
            Console.WriteLine(ch);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("String length is less than that index so can not reached");
            Console.WriteLine(e.Message);
        }
    }
}