using System;

class Handshaking
{
    public static void Main(String []args)
    {
        int totalStudents;
        int handshakes;

        Console.Write("Enter number of students: ");
        
        totalStudents = Convert.ToInt32(Console.ReadLine());

        // Formula: n * (n - 1) / 2
        handshakes = (totalStudents * (totalStudents - 1)) / 2;

        Console.WriteLine("The maximum number of possible handshakes is " + handshakes);
    }
}
