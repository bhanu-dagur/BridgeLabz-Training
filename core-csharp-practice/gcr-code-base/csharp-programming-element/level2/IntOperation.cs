using System;

class IntOperation
{
    static void Main()
    {
        int a, b, c;
        int ans1, ans2, ans3, ans4;

        Console.Write("Enter value of a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of c: ");
        c = Convert.ToInt32(Console.ReadLine());

        ans1 = a + b * c;
        ans2 = a * b + c;
        ans3 = c + a / b;
        ans4 = a % b + c;

        Console.WriteLine("The results of Int Operations are " +ans1 + ", "+ans2 + ", " +ans3 + ", and " +ans4);
    }
}
