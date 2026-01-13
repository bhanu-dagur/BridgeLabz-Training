using System;
using System.Text;
class CancatenateString
{
    public static void Main()
    {
        CancatenateString obj=new CancatenateString();
        string [] str={"hello ","world"};
        obj.Concatenate(str);
    }
    public void Concatenate(string [] str)
    {
        StringBuilder ans=new StringBuilder();
        for(int i = 0; i < str.Length; i++)
        {
            ans.Append(str[i]);
        }

        Console.WriteLine(ans);
    }
}