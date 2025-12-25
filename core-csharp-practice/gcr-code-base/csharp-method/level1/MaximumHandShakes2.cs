using System;

class MaximumHandShakes2
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        if (numberOfStudents < 0)
        {
            Console.WriteLine("Number of students must be positive");
            return;
        }

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("Maximum number of handshakes possible = " + handshakes);
    }
}
