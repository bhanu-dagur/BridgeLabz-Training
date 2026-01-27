using System;
using System.IO;
using System.Text;

class FilterStreams
{
    static void Main()
    {
        string sourceFile = "Source.text";
        string destinationFile = "output.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // --------- INPUT STREAM CHAIN ---------
            FileStream inputFs = new FileStream(
                sourceFile,
                FileMode.Open,
                FileAccess.Read
            );

            BufferedStream inputBuffer = new BufferedStream(inputFs);

            StreamReader reader = new StreamReader(
                inputBuffer,
                Encoding.UTF8   // handle character encoding
            );

            // --------- OUTPUT STREAM CHAIN ---------
            FileStream outputFs = new FileStream(
                destinationFile,
                FileMode.Create,
                FileAccess.Write
            );

            BufferedStream outputBuffer = new BufferedStream(outputFs);

            StreamWriter writer = new StreamWriter(
                outputBuffer,
                Encoding.UTF8
            );

            // --------- FILTER LOGIC ---------
            int ch;
            while ((ch = reader.Read()) != -1)
            {
                char currentChar = (char)ch;

                if (char.IsUpper(currentChar))
                {
                    currentChar = char.ToLower(currentChar);
                }

                writer.Write(currentChar);
            }

            // Flush & close
            writer.Flush();
            reader.Close();
            writer.Close();

            Console.WriteLine("File converted from uppercase to lowercase successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
/*
Open source file
 ↓
Read text (characters)
 ↓
Convert uppercase to lowercase
 ↓
Write converted text to destination file
 ↓
Close streams

*/
