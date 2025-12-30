using System;

class StudentQuize
{
    static void Main()
    {
        string[] correctAnswers =
        {
            "A", "B", "C", "D", "A",
            "C", "B", "D", "A", "C"
        };

        string[,] questions = Questions();

        string[] studentAnswer = TakeStudentAnswer(questions);

        int score = CalculateScore(correctAnswers, studentAnswer);

        Feedback(correctAnswers, studentAnswer);
        PassOrfail(score);
    }

    static string[] TakeStudentAnswer(string[,] questions)
    {
        string[] studentAnswer = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(questions[i, j]);
            }

            Console.Write("Enter the answer (A/B/C/D): ");
            studentAnswer[i] = Console.ReadLine();
        }
        return studentAnswer;
    }

    static string[,] Questions()
    {
        string[,] questions =
        {
            {
                "1. What is the full form of CPU?",
                "A) Central Processing Unit",
                "B) Computer Personal Unit",
                "C) Central Program Unit",
                "D) Control Processing Unit"
            },
            {
                "2. Which device is used to input data?",
                "A) Monitor",
                "B) Printer",
                "C) Keyboard",
                "D) Speaker"
            },
            {
                "3. Which of the following is an output device?",
                "A) Mouse",
                "B) Scanner",
                "C) Monitor",
                "D) Keyboard"
            },
            {
                "4. What is the brain of the computer?",
                "A) RAM",
                "B) Hard Disk",
                "C) CPU",
                "D) Motherboard"
            },
            {
                "5. Which memory is volatile?",
                "A) ROM",
                "B) Hard Disk",
                "C) RAM",
                "D) CD"
            },
            {
                "6. What does RAM stand for?",
                "A) Read Access Memory",
                "B) Random Access Memory",
                "C) Run Access Memory",
                "D) Read Actual Memory"
            },
            {
                "7. Which of these is a storage device?",
                "A) Keyboard",
                "B) Mouse",
                "C) Hard Disk",
                "D) Monitor"
            },
            {
                "8. What does OS stand for?",
                "A) Open Software",
                "B) Operating System",
                "C) Order System",
                "D) Output Software"
            },
            {
                "9. Which language is closest to machine language?",
                "A) High Level Language",
                "B) Assembly Language",
                "C) Java",
                "D) Python"
            },
            {
                "10. Which of the following is an input device?",
                "A) Printer",
                "B) Monitor",
                "C) Speaker",
                "D) Mouse"
            }
        };
        return questions;
    }

    static int CalculateScore(string[] correctMarks, string[] studentMarks)
    {
        int score = 0;
        for (int i = 0; i < studentMarks.Length; i++)
        {
            if (studentMarks[i].Equals(
                correctMarks[i],
                StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }
        return score;
    }

    static void Feedback(string[] correctMarks, string[] studentMarks)
    {
        Console.WriteLine("\n Feedback:");
        for (int i = 0; i < studentMarks.Length; i++)
        {
            if (studentMarks[i].Equals(
                correctMarks[i],
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question number " + (i + 1) + " is Correct ");
            }
            else
            {
                Console.WriteLine("Question number " + (i + 1) + " is Incorrect ");
            }
        }
    }

    static void PassOrfail(int score)
    {
        int percent = score * 10;

        if (percent > 33)
        {
            Console.WriteLine("\nStudent has PASSED");
        }
        else
        {
            Console.WriteLine("\nStudent has FAILED");
        }

        Console.WriteLine("Percentage: " + percent + "%");
    }
}
