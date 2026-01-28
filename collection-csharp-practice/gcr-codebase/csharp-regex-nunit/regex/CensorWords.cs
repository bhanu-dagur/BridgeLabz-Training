using System;
using System.Text.RegularExpressions;

class CensorWords
{
    static void Main()
    {
        string text = "This is a damn bad example with some stupid words.";
        string result = Regex.Replace(text, @"damn|stupid", "****", RegexOptions.IgnoreCase);
        Console.WriteLine(result);
    }
}
