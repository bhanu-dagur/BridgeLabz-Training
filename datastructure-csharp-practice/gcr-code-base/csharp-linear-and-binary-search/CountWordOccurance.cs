// Problem 2: Count the Occurrence of a Word in a File Using StreamReader
// Problem: Write a program that reads a file and counts how many times a specific word appears in the file.
using System;
using System.IO;
class CountWordOccurance
{
    static void Main()
    {
        string filePath=@"C:\Users\dell\OneDrive\Documents\BasicDBMS.txt";
        string word="the";

        StreamReader reader=new StreamReader(filePath);

        string line;
        int count=0;

        while ((line = reader.ReadLine()) != null)
        {
            string [] words=line.Split(' ');

            foreach (string w in words)
            {
                if (w == word)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("The word '{0}' appears {1} times in the file.", word,count);
    }
}