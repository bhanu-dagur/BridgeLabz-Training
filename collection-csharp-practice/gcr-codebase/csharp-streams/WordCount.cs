using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class WordCount
{
    static void Main()
    {
        string filePath = "Source.text";
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line
                        .ToLower()
                        .Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' },
                               StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }

            var topWords = wordCount
                .OrderByDescending(w => w.Value)
                .Take(5);

            Console.WriteLine("Top 5 most frequent words:");
            foreach (var item in topWords)
            {
                Console.WriteLine(item.Key + " → " + item.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
