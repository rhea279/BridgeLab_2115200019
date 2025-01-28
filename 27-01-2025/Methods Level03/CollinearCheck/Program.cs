using System;

class CollinearCheck
{
    static bool AreCollinearSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        return slopeAB == slopeBC;
    }

    static bool AreCollinearArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }

    static void Main()
    {
		Console.Write("Enter x1:");
		int x1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter y1:");
		int y1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter x2:");
		int x2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter y2:");
		int y2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter x3:");
		int x3 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter y3:");
		int y3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(AreCollinearSlope(x1,y1,x2,y2,x3,y3));
        Console.WriteLine(AreCollinearArea(x1,y1,x2,y2,x3,y3));
    }
}
