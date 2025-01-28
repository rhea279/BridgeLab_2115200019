using System;

class Geometry
{
    static double EuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static (double, double) LineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return (slope, yIntercept);
    }

    static void Main()
    {
        Console.Write("Enter x1, y1: ");
        var p1 = Console.ReadLine().Split();
        Console.Write("Enter x2, y2: ");
        var p2 = Console.ReadLine().Split();

        double x1 = double.Parse(p1[0]), y1 = double.Parse(p1[1]);
        double x2 = double.Parse(p2[0]), y2 = double.Parse(p2[1]);

        double distance = EuclideanDistance(x1, y1, x2, y2);
        var (slope, intercept) = LineEquation(x1, y1, x2, y2);

        Console.WriteLine($"Distance: {distance}");
        Console.WriteLine($"Equation: y = {slope}x + {intercept}");
    }
}
