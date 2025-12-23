using System;

class GradeCalculation
{
    static void Main()
    {
        double physics, chemistry, maths;
        double total, percent;
        string grade, remark;

        Console.Write("Enter Physics marks: ");
        physics = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        chemistry = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        maths = Convert.ToDouble(Console.ReadLine());

        total = physics + chemistry + maths;
        percent = total / 3;

        if (percent >= 80)
        {
            grade = "A";
            remark = "Level 4, above agency-normalized standards";
        }
        else if (percent >= 70)
        {
            grade = "B";
            remark = "Level 3, at agency-normalized standards";
        }
        else if (percent >= 60)
        {
            grade = "C";
            remark = "Level 2, below but approaching agency-normalized standards";
        }
        else if (percent >= 50)
        {
            grade = "D";
            remark = "Level 1, well below agency-normalized standards";
        }
        else if (percent >= 40)
        {
            grade = "E";
            remark = "Level 1, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remark = "Remedial standards";
        }

        Console.WriteLine("Average Marks: " + percent + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remark: " + remark);
    }
}
