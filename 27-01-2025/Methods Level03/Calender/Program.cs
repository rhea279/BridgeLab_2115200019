using System;

class Calendar
{
    static string GetMonthName(int month)
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    static int GetDaysInMonth(int year, int month)
    {
        if (month == 2)
        {
            return IsLeapYear(year) ? 29 : 28;
        }

        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return days[month - 1];
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static int GetFirstDayOfMonth(int year, int month)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        return (1 + x + (31 * m0) / 12) % 7;
    }

    static void DisplayCalendar(int year, int month)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(year, month);
        int firstDay = GetFirstDayOfMonth(year, month);

        Console.WriteLine($"\n   {monthName} {year}");
        Console.WriteLine(" Su Mo Tu We Th Fr Sa");

        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("   ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3}");
            if ((day + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        DisplayCalendar(year, month);
    }
}
