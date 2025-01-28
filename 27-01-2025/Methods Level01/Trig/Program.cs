using System;
class Trig
{
    static void Main(string[] args)
    {
        // Input the angle in degrees from the user
        Console.WriteLine("Enter an angle in degrees:");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Calculate trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine($"Sine: {results[0]:F4}");
        Console.WriteLine($"Cosine: {results[1]:F4}");
        Console.WriteLine($"Tangent: {(results[2] == double.PositiveInfinity ? "Undefined" : results[2].ToString("F4"))}");
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle to radians
        double radians = angle * (Math.PI / 180);

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = double.PositiveInfinity; // Default for undefined tangent

        // Handle tangent calculation, checking for undefined cases (cosine = 0)
        if (cosine != 0)
        {
            tangent = Math.Tan(radians);
        }

        // Return results in an array
        return new double[] { sine, cosine, tangent };
    }
}
