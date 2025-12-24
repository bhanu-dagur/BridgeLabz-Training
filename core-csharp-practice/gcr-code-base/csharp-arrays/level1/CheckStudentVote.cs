using System;
using System.Data;
class CheckStudentVote
{
    static void Main()
    {
        int []student=new int[10];
        Console.WriteLine("Enter the age of Student");
        for(int i = 0; i < student.Length; i++)
        {
            student[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i <= student.Length; i++)
        {
            int age=student[i];
            if (age < 0)
            {
                Console.WriteLine("Age is not Valid");
            }
            else if (age < 18)
            {
                Console.WriteLine("The student with the age "+ age +" can not vote.");
            }
            else
            {
                Console.WriteLine("The student with the age "+ age +" can  vote.");
            }
        }

    }
}