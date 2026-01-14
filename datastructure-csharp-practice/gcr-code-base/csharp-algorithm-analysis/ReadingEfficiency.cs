using System;
using System.IO;
class ReadingEfficiency
{
    static void Main()
    {
        // insert the file path or file
        // string filePath="C:/Users/dell/OneDrive/Documents/BasicDBMS.txt";
        string filePath=@"C:\Users\dell\OneDrive\Documents\BasicDBMS.txt";

        StreamReader reader = new StreamReader(filePath);

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        // cose the reader
        reader.Close();

    }
}