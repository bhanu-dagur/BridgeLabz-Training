using System;

class MaximumHandShakes1
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Number of students must be positive");
            return;
        }

        int handshakes = FindHandshakes(n);

        Console.WriteLine("Maximum number of handshakes among " + n +
                          " students is " + handshakes);
    }

    // Method to calculate handshakes
    static int FindHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}
