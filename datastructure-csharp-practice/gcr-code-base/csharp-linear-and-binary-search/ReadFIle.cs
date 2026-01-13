// Problem 1: Read a File Line by Line Using StreamReader
// Problem: Write a program that uses StreamReader to read a text file line by line and print each line to the console.

using System;
using System.IO;
class ReadFIle
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