using System;

class BMICalculator
{
    // Method to calculate BMI and populate the 3rd column of the array
    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = data[i, 0]; // in kg
            double heightCm = data[i, 1]; // in cm
            double heightM = heightCm / 100; // convert to meters
            double bmi = weight / (heightM * heightM);
            data[i, 2] = bmi; // store BMI in 3rd column
        }
    }

    // Method to get BMI status based on BMI value
    public static string GetBMIStatus(double bmi)
    {
        if (bmi <= 18.4)
            return "Underweight";
        else if (bmi >= 18.5 && bmi <= 24.9)
            return "Normal";
        else if (bmi >= 25.0 && bmi <= 39.9)
            return "Overweight";
        else // bmi >= 40.0
            return "Obese";
    }

    static void Main(string[] args)
    {
        double[,] data = new double[10, 3]; // weight, height, BMI

        // Input weight and height
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
            data[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
            data[i, 1] = double.Parse(Console.ReadLine());
        }

        // Calculate BMI
        CalculateBMI(data);

        // Display results
        Console.WriteLine("\nPerson\tWeight(kg)\tHeight(cm)\tBMI\tStatus");
        for (int i = 0; i < 10; i++)
        {
            double weight = data[i, 0];
            double height = data[i, 1];
            double bmi = Math.Round(data[i, 2], 2);
            string status = GetBMIStatus(bmi);

            Console.WriteLine((i + 1) + "\t" + weight + "\t\t" + height + "\t\t" + bmi + "\t" + status);
        }
    }
}
