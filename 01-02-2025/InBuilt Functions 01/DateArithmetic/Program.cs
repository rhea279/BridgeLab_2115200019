using System;
class DateArithmetic
{
    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        // Perform date arithmetic
        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2); // Add 7 days, 1 month, 2 years
        newDate = newDate.AddDays(-21); // Subtract 3 weeks (21 days)

        // Display the result
        Console.WriteLine($"Final Date after modifications: {newDate:yyyy-MM-dd}");
    }
}
