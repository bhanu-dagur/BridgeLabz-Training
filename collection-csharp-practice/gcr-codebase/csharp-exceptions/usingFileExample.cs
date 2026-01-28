using System;
using System.IO;

class UsingFileExample
{
    static void Main()
    {
        try
        {
            // using ensures the file is closed automatically
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                // Read only the first line
                string firstLine = reader.ReadLine();

                Console.WriteLine("First line of file:");
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
