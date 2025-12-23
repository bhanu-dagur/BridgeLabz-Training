using System;

class CalculateBMI
{
    static void Main()
    {
        double weightKg, heightCm, heightM, bmi;
        string status;

        Console.Write("Enter weight (in kg): ");
        weightKg = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height (in cm): ");
        heightCm = Convert.ToDouble(Console.ReadLine());

        // Convert height from cm to meters
        heightM = heightCm / 100;

        bmi = weightKg / (heightM * heightM);

        if (bmi <= 18.4)
        {
            status = "Underweight";
        }
        else if (bmi <= 24.9)
        {
            status = "Normal";
        }
        else if (bmi <= 39.9)
        {
            status = "Overweight";
        }
        else
        {
            status = "Obese";
        }
        Console.WriteLine("BMI Value: " + bmi);
        Console.WriteLine("Weight Status: " + status);
    }
}
