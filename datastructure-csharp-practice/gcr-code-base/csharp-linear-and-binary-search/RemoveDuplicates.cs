using System;
using System.Text;
class RemoveDuplicates
{
    public static void Main()
    {
        string str="hello world";
        RemoveDuplicates obj=new RemoveDuplicates();
        obj.Remove(str);
    }
    public void Remove(string str)
    {
        StringBuilder seen=new StringBuilder();
        for(int i=0;i<str.Length;i++)
        {
            bool isDuplicate=false;
            char ch=str[i];
            for(int j = 0; j < seen.Length; j++)
            {
                if(seen[j]==ch)   isDuplicate=true;
            }
            if(!isDuplicate) seen.Append(ch);
        }
        
        Console.WriteLine(seen);
    }
}