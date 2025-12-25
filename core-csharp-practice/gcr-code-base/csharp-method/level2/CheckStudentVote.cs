using System;

public class CheckStudentVote
{
    static void Main(string[] args)
    {
        int[] age = new int[10];
        CheckStudentVote checker = new CheckStudentVote();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            age[i] = int.Parse(Console.ReadLine());

            bool canVote = checker.CanStudentVote(age[i]);
            if (canVote)
                Console.WriteLine("Student " + (i + 1) + " can vote.");
            else
                Console.WriteLine("Student " + (i + 1) + " cannot vote.");
        }
    }
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            Console.WriteLine("Invalid age: " + age);
            return false;
        }
        else if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
