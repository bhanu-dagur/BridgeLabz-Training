using System;

class NestedTryCatch
{
    static void Main()
    {
        int[] arr = { 10, 20, 30 };

        try
        {
            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.Write("Enter divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                int result = arr[index] / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}
