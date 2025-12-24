using System;

class YoungestFriend
{
    static void Main()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };

        int[] age = new int[3];
        double[] height = new double[3];

        //Taking input
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age of " + names[i] + ": ");
            age[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of " + names[i] + " (in cm): ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Finding youngest and tallest
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngestIndex])
            {
                youngestIndex = i;
            }

            if (height[i] > height[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        
        Console.WriteLine("\nYoungest Friend : " + names[youngestIndex] +
         " (Age: " + age[youngestIndex] + ")");

        Console.WriteLine("Tallest Friend  : " + names[tallestIndex] +
          " (Height: " + height[tallestIndex] + " cm)");
    }
}
