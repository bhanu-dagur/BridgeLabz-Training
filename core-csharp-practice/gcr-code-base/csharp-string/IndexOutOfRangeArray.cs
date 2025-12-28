using System;
class IndexOutOfRangeArray
{
    static void Main()
    {
        string [] s={"b","h","a","n","u"};
        CheckIndexException(s);
    }
    static void CheckIndexException(string [] s)
    {
        try
        {
            string str=s[11];
            Console.WriteLine(str);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("String length is less than that index so can not reached");
            Console.WriteLine(e.Message);
        }
    }
}