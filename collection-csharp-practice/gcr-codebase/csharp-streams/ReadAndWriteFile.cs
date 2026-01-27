using System;
using System.IO;

class ReadAndWriteFile
{
    static void Main()
    {
        string sourcePath="Source.text";
        string destinationPath="Destination.txt";

        try
        {
            // check source file exit or not 

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exit ");
                return;
            }
            // open source file in reading mode

            FileStream sourceStream=new FileStream(sourcePath,FileMode.Open,FileAccess.Read);

            // open destination file in writemode 

            FileStream destinationStream=new FileStream(destinationPath,FileMode.Create,FileAccess.Write);

            // Read and Write Byte by byte

            int data;
            while ((data = sourceStream.ReadByte()) != -1)
            {
                destinationStream.WriteByte((Byte)data);
            }

            sourceStream.Close();
            destinationStream.Close();

            Console.WriteLine("File copied Sucessfully");
        }
        catch(IOException ex)
        {
            Console.WriteLine("An IO error occurred: "+ ex.Message);
        }


    }
}
/*
Start
 ↓
Check source file exist?
 ↓
No → Print message → End
 ↓
Yes
 ↓
Open source FileStream (Read)
 ↓
Open destination FileStream (Write)
 ↓
Read byte → Write byte (Loop)
 ↓
Close files
 ↓
End
*/