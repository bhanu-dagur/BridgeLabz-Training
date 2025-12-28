using System;
class MostFrequent
{
    static void Main()
    {
        Console.WriteLine("Enter the string");
        string s=Console.ReadLine();
        int []freq=new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            freq[s[i]-'a']++;
        }

        char maxFreq=' ';
        int max=0;
        for(int i = 0; i < s.Length; i++)
        {
            if (freq[s[i]-'a'] > max)
            {
                maxFreq=s[i];
                max=freq[s[i]-'a'];
            }
        }
        Console.WriteLine("Most Frequent Character :"+maxFreq);
    }
}