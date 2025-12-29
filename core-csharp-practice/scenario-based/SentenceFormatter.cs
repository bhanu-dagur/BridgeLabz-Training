using System;

class SentenceFormatter
{
    static void Main()
    {
        Console.WriteLine("Enter the paragraph:");
        string sentence = Console.ReadLine();

        // Edge case: empty or only spaces
        if (IsEmptyOrSpaces(sentence))
        {
            Console.WriteLine("Paragraph is empty or contains only spaces.");
            return;
        }

        int wordCount = CountWords(sentence);
        Console.WriteLine("Word Count: " + wordCount);

        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("Longest Word: " + longestWord);

        Console.WriteLine("Enter word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter new word:");
        string newWord = Console.ReadLine();

        string result = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Updated Paragraph:");
        Console.WriteLine(result);
    }

    // Check empty or only spaces
    static bool IsEmptyOrSpaces(string sentence)
    {
        if (sentence.Length == 0)
            return true;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
                return false;
        }
        return true;
    }

    // Count words manually
    static int CountWords(string sentence)
    {
        int count = 0;
        bool inWord = false;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ' && !inWord)
            {
                count++;
                inWord = true;
            }
            else if (sentence[i] == ' ')
            {
                inWord = false;
            }
        }
        return count;
    }

    // Find longest word manually
    static string FindLongestWord(string sentence)
    {
        string longest = "";
        string current = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                current += sentence[i];
            }
            else
            {
                if (current.Length > longest.Length)
                {
                    longest = current;
                }
                current = "";
            }
        }

        // Last word check
        if (current.Length > longest.Length)
        {
            longest = current;
        }

        return longest;
    }

    // Replace word manually (case-insensitive)
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        string current = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                current += sentence[i];
            }
            else
            {
                if (IsEqualIgnoreCase(current, oldWord))
                {
                    result += newWord;
                }
                else
                {
                    result += current;
                }
                result += " ";
                current = "";
            }
        }

        // Last word
        if (IsEqualIgnoreCase(current, oldWord))
        {
            result += newWord;
        }
        else
        {
            result += current;
        }

        return result;
    }

    // Case-insensitive comparison without inbuilt methods
    static bool IsEqualIgnoreCase(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            char c1 = a[i];
            char c2 = b[i];

            // Convert to lowercase manually
            if (c1 >= 'A' && c1 <= 'Z')
                c1 = (char)(c1 + 32);
            if (c2 >= 'A' && c2 <= 'Z')
                c2 = (char)(c2 + 32);

            if (c1 != c2)
                return false;
        }
        return true;
    }
}
