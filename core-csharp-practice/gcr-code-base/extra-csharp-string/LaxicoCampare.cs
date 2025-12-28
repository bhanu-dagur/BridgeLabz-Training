using System;
class LaxicoCampare
{
    static void Main()
    {
        Console.WriteLine("Enter the first string ");
        string s1=Console.ReadLine();
        Console.WriteLine("enter the second string");
        string s2=Console.ReadLine();

        if (s1.Length < s2.Length)
        {
            for(int i = 0; i < s1.Length; i++)
            {
                if (s2[i] < s1[i])
                {
                    Console.WriteLine(s2 +" comes before "+s1+" in lexicographical order");
                    break;
                }
                else if(s1[i]<s2[i])
                {
                    Console.WriteLine(s1 +" comes before "+s2+" in lexicographical order");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        else
        {
            for(int i = 0; i < s2.Length; i++)
            {
                if (s1[i] < s2[i])
                {
                    Console.WriteLine(s1 +" comes before "+s2+" in lexicographical order");
                    break;
                }
                else if(s2[i]<s1[i])
                {
                    Console.WriteLine(s2 +" comes before "+s1+" in lexicographical order");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}