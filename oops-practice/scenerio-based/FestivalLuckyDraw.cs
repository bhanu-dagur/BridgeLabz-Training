using System;

class Visitor
{
    int number;

    public Visitor(int number)
    {
        this.number = number;
    }

    public void IsLucky()
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("YOU ARE LUCKY, SO YOU WIN THE GIFT");
        }
        else
        {
            Console.WriteLine("YOU ARE NOT LUCKY");
        }
    }
}

class FestivalLuckyDraw
{
    public static void Main()
    {
        Console.WriteLine("ENTER THE NUMBER OF VISITORS");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("GUESS THE NUMBER");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("ENTER VALID NUMBER");
                continue;
            }

            Visitor v = new Visitor(number);
            v.IsLucky();
        }
    }
}
