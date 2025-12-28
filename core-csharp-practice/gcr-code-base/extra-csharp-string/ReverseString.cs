using System;
class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter the string");
        string s=Console.ReadLine();
        
        string reverseString="";
        for(int i = s.Length - 1; i >= 0; i--)
        {
            reverseString+=s[i];

        }
        Console.WriteLine("Reverse string  is: "+reverseString );
        
    }
}