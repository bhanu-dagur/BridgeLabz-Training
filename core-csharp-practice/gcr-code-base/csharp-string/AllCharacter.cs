using System;
using System.Reflection.PortableExecutable;
class AllCharacter
{
    static void Main()
    {
        Console.WriteLine("Enter the string");
        string s=Console.ReadLine();
        char []result1=FindCharArray(s);
        char []result2=s.ToCharArray();
        if (ArrayCheck(result1,result2))
        {
            Console.WriteLine("\nBoth array are equal");
        }
        else
            Console.WriteLine("\nboth arrays are not equal");
    }
    static char[] FindCharArray(string s)
    {
        Char[] ans=new Char[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            ans[i]=s[i];
            Console.Write(ans[i]+" ");
        }
        return ans;
    }
    static bool ArrayCheck(char []arr1,char[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }
        for(int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
            
        }
        return true;
    } 

}