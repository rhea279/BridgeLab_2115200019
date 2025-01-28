using System;

class StudentScorecard
{
    static string AssignGrade(double percentage)
    {
        if (percentage >= 80) return "Above agency-normalized standards";
        else if (percentage >= 70) return "At agency-normalized standards";
        else if (percentage >= 60) return "Below, but approaching agency-normalized standards";
        else if (percentage >= 50) return "Well below agency-normalized standards";
        else if (percentage >= 40) return "Too below agency-normalized standards";
        else return "Remedial standards";
    }

    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numStudents; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i}:");
            Console.Write("Physics: ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Chemistry: ");
            int chemistry = int.Parse(Console.ReadLine());

            Console.Write("Math: ");
            int math = int.Parse(Console.ReadLine());

            // Calculating total, average, and percentage
            int total = physics + chemistry + math;
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;
            string grade = AssignGrade(percentage);  // Changed from char to string

            // Displaying Results
            Console.WriteLine("\nStudent Scorecard:");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
