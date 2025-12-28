using System;
class RemoveDuplicate
{
    static void Main()
    {
        Console.WriteLine("Enter the String");
        string s=Console.ReadLine();

        string modified="";

        for(int i = 0; i < s.Length; i++)
        {
            if (modified.Contains(s[i].ToString()))
            {
                continue;
            }
            else
            {
                modified+=s[i];
            }
        }
        Console.WriteLine("String after remove of duplicate character: "+modified);
    }
}