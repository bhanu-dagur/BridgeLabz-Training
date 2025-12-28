using System;
class ArgumentOutOfRange
{
    static void Main()
    {
        string s="bhnau-dagur";
        CheckArgumentException(s);
    }
    static void CheckArgumentException(string s)
    {
        try
        {
            string sub=s.Substring(11,3);
            Console.WriteLine("SubString is ");
        }
        catch(ArgumentOutOfRangeException e)
        {
            Console.WriteLine("String length  is less than the given index");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.GetType());
        }
    }
}