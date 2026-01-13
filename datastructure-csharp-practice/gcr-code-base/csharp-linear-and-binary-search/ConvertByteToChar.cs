using System;
using System.IO;

class ConvertByteToChar
{
    static void Main()
    {
        // File path (text file stored as bytes)
        string path = @"C:\Users\dell\OneDrive\Documents\BasicDBMS.txt";

        // StreamReader converts byte stream to character stream
        using (StreamReader reader = new StreamReader(path))
        {
            int ch;

            // Read character by character
            while ((ch = reader.ReadByte()) != -1)
            {
                Console.Write((char)ch);
            }
        }
    }
}
