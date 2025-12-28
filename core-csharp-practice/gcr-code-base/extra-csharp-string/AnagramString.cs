using System;
class AnagramString
{
    static void Main()
    {
        Console.WriteLine("Enter the first string");
        string s1=Console.ReadLine();

        Console.WriteLine("Enter the second string");
        string s2=Console.ReadLine();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("string are not Anagram");

        }
        else
        {
            for(int i = 0; i < s1.Length; i++)
            {
                int index=s2.IndexOf(s1[i]);
                if (index != -1)
                {
                    s2=s2.Remove(index,1);
                }
            }
            if (s2.Length == 0)
            {
                Console.WriteLine("String are Anagram");
            }
            else
            {
                Console.WriteLine("String are not Anagram");
            }
        }

        

    }
}