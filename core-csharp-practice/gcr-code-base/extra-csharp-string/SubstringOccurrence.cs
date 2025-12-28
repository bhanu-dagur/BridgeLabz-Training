using System;
class SubstringOccurrence
{
    static void Main()
    {
        Console.WriteLine("Enter the String");
        string s=Console.ReadLine();
        Console.WriteLine("Enter the SubString");
        string subString =Console.ReadLine();
        int len=subString.Length;

        int count=0;

        for(int i = 0; i <=s.Length-len; i++)
        {
            if (s.Substring(i,len)==subString)
            {
                count++;
            }

        }
        Console.WriteLine("total substring is: "+count);
        

    }
}