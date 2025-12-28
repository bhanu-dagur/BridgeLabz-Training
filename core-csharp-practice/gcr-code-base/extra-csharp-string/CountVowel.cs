using System;
class CountVowel
{
    static void Main()
    {
        Console.WriteLine("Enter the string");
        string s=Console.ReadLine();

        int vowelCount=0;
        int consonantCount=0;

        for(int i = 0; i < s.Length; i++)
        {
            char ch=s[i];
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch == 'u' ||
            ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch == 'U' )
            {
                vowelCount++;
            }
            else
            {
                onsonantCount++;
            }
        }
        Console.WriteLine("total vowels in the given string: "+ vowelCount);
        Console.WriteLine("total consonant in the given stirng: "+consonantCount);
    }
}