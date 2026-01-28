using System;

class DivisionExample
{
    static void Main()
    {
        try
        {
            // Step 1: First number input
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Step 2: Second number input
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Step 3: Division
            int result = num1 / num2;

            // Step 4: Print result
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Something went wrong");
        }
    }
}
