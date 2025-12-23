using System;
class DayOfWeak
{
    static void Main()
    {
        int year,month,day;
        Console.WriteLine("enter year of date");
        year=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the month of date");
        month=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the date ");
        day=int.Parse(Console.ReadLine());

        // day calculation formula
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0/4 -y0/100 + y0/400;
        int m0 = month + 12*((14 -month) / 12) - 2;
        int d0 = (day+ x + 31*m0 / 12) %7;

        switch (d0)
        {
            case 0:
            Console.WriteLine("Sunday");
            break;
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            case 4:
            Console.WriteLine("Thrusday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
            default :
            Console.WriteLine("Invalid date");
            break;

        }
    }
}