using System;

class HandlingMultipleExceptions
{
    static void Main()
    {
        try
        {
            
            int[] arr = { 10, 20, 30, 40, 50 };

           
            arr = null;

            // Step 2: Take index from user
            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            // Step 3: Access array element
            int value = arr[index];

            // Step 4: Print result
            Console.WriteLine("Value at index " + index + ": " + value);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (Exception)
        {
            Console.WriteLine("Something went wrong");
        }
    }
}
