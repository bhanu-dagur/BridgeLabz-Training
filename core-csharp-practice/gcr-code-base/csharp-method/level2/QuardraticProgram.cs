using System;

class QuadraticProgram
{
    // Method to find roots of quadratic equation
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c; 

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            // One real root
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            // No real roots
            return new double[] { }; // empty array
        }
    }

    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots exist for the given quadratic equation.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("The quadratic equation has one root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("The quadratic equation has two roots: " + roots[0] + " and " + roots[1]);
        }
    }
}
