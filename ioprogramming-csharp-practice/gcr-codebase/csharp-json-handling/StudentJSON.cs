using System;
using Newtonsoft.Json;

class StudentJSON
{
    static void Main()
    {
        var student = new
        {
            name = "Bhanu",
            age = 22,
            subjects = new[] { "Maths", "Science", "Computer" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}
