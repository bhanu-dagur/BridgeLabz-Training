using System;
class ToLowerCase
{
    static void Main()
    {
        string s="BHANU-DAGUR";
        ConvertLowerCase(s);
        Console.WriteLine("Given String s;"+s);
        Console.WriteLine("lower case using built in function: "+s.ToLower());
        
        
    }
    static void ConvertLowerCase(string s)
    {
        string result="";

        char ch;
        // convert to lower case using ascii value
        for(int i = 0; i < s.Length; i++)
        {
            
            if(s[i]>='A' && s[i] <= 'Z')
            {
                ch=(char)(s[i]+32);
                result=result+ch;
            }
            else
            {
                result=result+s[i];
            }
        }
        Console.WriteLine("lower case using ascii value: "+result);
    }

}