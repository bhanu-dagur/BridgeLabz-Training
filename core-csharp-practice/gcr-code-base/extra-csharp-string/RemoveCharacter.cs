using System;
class RemoveCharacter
{
    static void Main()
    {
        Console.WriteLine("Enter the string ");
        string s=Console.ReadLine();

        Console.WriteLine("Enter the character that you removed from the string ");
        char ch=Convert.ToChar(Console.ReadLine());

        string ans="";

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == ch)
            {
                continue;
            }
            else
            {
                ans+=s[i];
            }
        }

        Console.WriteLine(s+ " arfer removal of character "+ch);
        Console.Write("Modified String :" +ans);

    }
}