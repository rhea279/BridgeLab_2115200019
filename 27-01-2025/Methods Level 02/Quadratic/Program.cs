using System;

class Quadratic
{
    // Method to find the roots of a quadratic equation
    static double[] FindRoots(int a, int b, int c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c; // Calculate delta (b^2 - 4ac)

        if (delta > 0)
        {
            // Two distinct roots
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            // One root (double root)
            double root = -b / (2.0 * a);
            return new double[] { root };
        }
        else
        {
            // No real roots (delta < 0)
            return new double[0];
        }
    }

    static void Main(string[] args)
    {
        // Input coefficients a, b, and c
        Console.WriteLine("Enter coefficient a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coefficient b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter coefficient c:");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Coefficient 'a' cannot be zero in a quadratic equation.");
            return;
        }

        // Call the method to find the roots
        double[] roots = FindRoots(a, b, c);

        // Display the results
        if (roots.Length == 2)
        {
            Console.WriteLine($"The roots are: {roots[0]} and {roots[1]}");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The root is: {roots[0]}");
        }
        else
        {
            Console.WriteLine("No real roots exist.");
        }
    }
}
