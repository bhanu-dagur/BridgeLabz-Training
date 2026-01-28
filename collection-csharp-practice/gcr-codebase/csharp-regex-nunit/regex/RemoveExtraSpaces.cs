using System;
using System.Text.RegularExpressions;

class RemoveExtraSpaces
{
    static void Main()
    {
        string input = "This   is    an   example    with   spaces.";
        string output = Regex.Replace(input, @"\s+", " ");
        Console.WriteLine(output);
    }
}
