using System;
class ToUpperCase
{
    static void Main()
    {
        string s="bhanudagur";

        // toUpper case using Ascii value;
        ConvertUpperCase(s);
        Console.WriteLine("original string : "+s);
        Console.WriteLine("Convert in upper case using built in method: "+s.ToUpper());
        
    }
    static void ConvertUpperCase(string s)
    {
        string ans="";
        char temp;
        for(int i = 0; i < s.Length; i++)
        {
            // computer always campare the character using its ascii value
            if(s[i]>='a' && s[i] <= 'z')
            {
                //char - int = int
                temp=(char)(s[i]-32);
                ans=ans+temp;
            }
            else
            {
                ans=ans+s[i];
            }
        }
        
        Console.WriteLine("Covert in upper case using ascii: "+ans);
        
    }
}