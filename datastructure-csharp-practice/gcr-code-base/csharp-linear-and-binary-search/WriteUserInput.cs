using System;
using System.IO;


class WriteUserInput
{
    static void Main()
    {
        string path=@"C:\Users\dell\OneDrive\Documents\BasicDBMS.txt";
        Console.WriteLine("Enter the text:");
        string text=Console.ReadLine();

        StreamWriter writer=new StreamWriter(path);
        // to append text to the file

        StreamWriter writer1=new StreamWriter(path,true);
        
        writer.WriteLine(text);
        writer.Close();
    }
}