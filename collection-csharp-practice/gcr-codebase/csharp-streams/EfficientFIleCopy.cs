using System;
using System.IO;
using System.Diagnostics;

class FileCopyPerformanceComparison
{
    static void Main()
    {
        string sourcePath = "BigFile.dat";           
        string normalDest = "copy_normal.dat";       
        string bufferedDest = "copy_buffered.dat";   

        int bufferSize = 4096; // 4 KB
        byte[] buffer = new byte[bufferSize];

        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // ---------------- NORMAL FILESTREAM ----------------
            Stopwatch normalWatch = new Stopwatch();

            FileStream normalRead = new FileStream(
                sourcePath,
                FileMode.Open,
                FileAccess.Read
            );

            FileStream normalWrite = new FileStream(
                normalDest,
                FileMode.Create,
                FileAccess.Write
            );

            normalWatch.Start();

            int bytesRead;
            while ((bytesRead = normalRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                normalWrite.Write(buffer, 0, bytesRead);
            }

            normalWatch.Stop();

            normalRead.Close();
            normalWrite.Close();

            Console.WriteLine(
                "Normal FileStream Time: " + normalWatch.ElapsedMilliseconds + " ms"
            );

            // ---------------- BUFFERED STREAM ----------------
            Stopwatch bufferedWatch = new Stopwatch();

            FileStream bufferedReadFs = new FileStream(
                sourcePath,
                FileMode.Open,
                FileAccess.Read
            );

            FileStream bufferedWriteFs = new FileStream(
                bufferedDest,
                FileMode.Create,
                FileAccess.Write
            );

            BufferedStream bufferedRead = new BufferedStream(bufferedReadFs);
            BufferedStream bufferedWrite = new BufferedStream(bufferedWriteFs);

            bufferedWatch.Start();

            while ((bytesRead = bufferedRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bufferedWrite.Write(buffer, 0, bytesRead);
            }

            bufferedWatch.Stop();

            bufferedRead.Close();
            bufferedWrite.Close();

            Console.WriteLine(
                "BufferedStream Time: " + bufferedWatch.ElapsedMilliseconds + " ms"
            );
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
