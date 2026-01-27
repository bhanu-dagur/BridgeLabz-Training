using System;
using System.IO;

class ImageByteArrayStream
{
    static void Main()
    {
        string sourceImage = "original.jpg";
        string newImage = "copy.jpg";

        try
        {
            // ---------------- STEP 1: Read image file into byte array ----------------
            byte[] imageBytes = File.ReadAllBytes(sourceImage);

            Console.WriteLine("Image converted to byte array.");
            Console.WriteLine("Byte Array Length: " + imageBytes.Length);

            // ---------------- STEP 2: Use MemoryStream ----------------
            MemoryStream memoryStream = new MemoryStream();

            // Write byte array into MemoryStream
            memoryStream.Write(imageBytes, 0, imageBytes.Length);

            // Move pointer back to beginning
            memoryStream.Position = 0;

            // ---------------- STEP 3: Write bytes back to new image file ----------------
            FileStream fileStream = new FileStream(
                newImage,
                FileMode.Create,
                FileAccess.Write
            );

            memoryStream.CopyTo(fileStream);

            fileStream.Close();
            memoryStream.Close();

            Console.WriteLine("New image created from byte array.");

            // ---------------- STEP 4: Verify both images ----------------
            byte[] originalBytes = File.ReadAllBytes(sourceImage);
            byte[] copiedBytes = File.ReadAllBytes(newImage);

            bool isSame = originalBytes.Length == copiedBytes.Length;

            if (isSame)
            {
                for (int i = 0; i < originalBytes.Length; i++)
                {
                    if (originalBytes[i] != copiedBytes[i])
                    {
                        isSame = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isSame ? "Images are identical " : "Images are NOT identical ");
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
