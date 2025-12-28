using System;
class ConvertTextToWord
{
    static int wordCount=1;
    static void Main()
    {
        Console.WriteLine("enter the text");
        string s=Console.ReadLine();
        // count number of word 
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]==' ')
            {
                wordCount++;
            }
        }

        string [,] ans=ToWord(s);
        for(int i = 0; i < wordCount; i++)
        {
            Console.WriteLine(ans[i,0]+" : "+ans[i,1]);
        }

    }
    static string [,] ToWord(string text)
    {
        
        string [,] arr=new string[wordCount,2];
        string word="";
        int index=0;
        for(int i = 0; i < text.Length; i++)
        {
            if(text[i]!=' ')
            {
                word=word+text[i];

            }
            else
            {
                arr[index,0]=word;
                int length=FindLength(word);
                arr[index,1]=length.ToString();
                index++;
                word="";
                

            }
        }
        // insert the last word 
        arr[index ,0]=word;
        arr[index ,1]=FindLength(word).ToString();
        return arr;
    }
    static int FindLength(String word)
    {
        int len=0;
        foreach(char ch in word)
        {
            len++;
        }
        return len;
    }
}