using System;
using System.IO;

class FileRead
{
    public static void Main()
    {
        try
        {
            string filepath="data.txt";

            string content=File.ReadAllText(filepath);

            Console.WriteLine("File Content:"+content);
            
        }
        catch (IOException )
        {
            Console.WriteLine("file not found");
        }
    }
}