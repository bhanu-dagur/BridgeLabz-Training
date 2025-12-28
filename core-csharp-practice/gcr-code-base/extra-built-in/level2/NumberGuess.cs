using System;

class NumberGuess
{
    static Random rand = new Random();

    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100");
        Console.WriteLine("Press Enter when ready...");
        Console.ReadLine();

        bool correct = false;

        while (!correct)
        {
            int guess = GenerateGuess();
            Console.WriteLine("Computer guess: " + guess);

            char feedback = GetFeedback();

            if (feedback == 'c')
            {
                Console.WriteLine("🎉 Correct guess!");
                correct = true;
            }
        }
    }
    static int GenerateGuess()
    {
        return rand.Next(1, 101); // 1 to 100
    }

    static char GetFeedback()
    {
        Console.WriteLine("Enter feedback:");
        Console.WriteLine("h = too high");
        Console.WriteLine("l = too low");
        Console.WriteLine("c = correct");

        return Console.ReadLine().ToLower()[0];
    }
}
