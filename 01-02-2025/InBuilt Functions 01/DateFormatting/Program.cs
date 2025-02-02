using System;
class DateFormat
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        // Display current date in different formats
        Console.WriteLine($"Format 1 (dd/MM/yyyy): {currentDate:dd/MM/yyyy}");
        Console.WriteLine($"Format 2 (yyyy-MM-dd): {currentDate:yyyy-MM-dd}");
        Console.WriteLine($"Format 3 (EEE, MMM dd, yyyy): {currentDate:ddd, MMM dd, yyyy}");
    }
}
