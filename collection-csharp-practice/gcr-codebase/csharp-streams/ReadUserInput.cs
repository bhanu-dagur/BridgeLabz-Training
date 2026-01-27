using System;
using System.IO;

class ReadUserInput
{
    static void Main()
    {
        string filePath = "UserInfo.txt";

        StreamReader reader = null;
        StreamWriter writer = null;

        try
        {
            // StreamReader for Console Input
            reader = new StreamReader(Console.OpenStandardInput());

            Console.Write("Enter your name: ");
            string name = reader.ReadLine();

            Console.Write("Enter your age: ");
            string age = reader.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine();

            // StreamWriter for File Output
            writer = new StreamWriter(filePath);

            writer.WriteLine("User Details");
            writer.WriteLine("------------");
            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);

            Console.WriteLine("\nData saved successfully into file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
        finally
        {
            // Close streams safely
            if (reader != null)
                reader.Close();

            if (writer != null)
                writer.Close();
        }
    }
}
