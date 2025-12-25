using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }

    static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
