using System;

class EmployeeBonus
{
    static (int salary, int yearsOfService)[] GenerateEmployees(int numEmployees)
    {
        Random random = new Random();
        var employees = new (int, int)[numEmployees];

        for (int i = 0; i < numEmployees; i++)
        {
            employees[i] = (random.Next(30000, 100000), random.Next(1, 15)); // Salary between 30k-100k, Years 1-15
        }

        return employees;
    }

    static (int newSalary, double bonus)[] CalculateBonuses((int salary, int yearsOfService)[] employees)
    {
        var bonuses = new (int, double)[employees.Length];

        for (int i = 0; i < employees.Length; i++)
        {
            double rate = employees[i].yearsOfService > 5 ? 0.05 : 0.02;
            double bonus = employees[i].salary * rate;
            int newSalary = employees[i].salary + (int)bonus;
            bonuses[i] = (newSalary, bonus);
        }

        return bonuses;
    }

    static void DisplaySummary((int salary, int yearsOfService)[] employees, (int newSalary, double bonus)[] bonuses)
    {
        int totalOldSalary = 0, totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Employee\tOld Salary\tYears\tBonus\t\tNew Salary");
        for (int i = 0; i < employees.Length; i++)
        {
            totalOldSalary += employees[i].salary;
            totalNewSalary += bonuses[i].newSalary;
            totalBonus += bonuses[i].bonus;

            Console.WriteLine($"{i + 1}\t\t{employees[i].salary}\t\t{employees[i].yearsOfService}\t{bonuses[i].bonus:F2}\t\t{bonuses[i].newSalary}");
        }

        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
        Console.WriteLine($"Total Bonus: {totalBonus:F2}");
    }

    static void Main()
    {
        const int numEmployees = 10;
        var employees = GenerateEmployees(numEmployees);
        var bonuses = CalculateBonuses(employees);
        DisplaySummary(employees, bonuses);
    }
}
