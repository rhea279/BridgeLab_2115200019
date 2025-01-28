using System;

class BMI
{
    // Method to calculate BMI for each team member
    static void CalculateBMI(double[,] team)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = team[i, 0];
            double height = team[i, 1] / 100; // Convert height from cm to meters
            team[i, 2] = weight / (height * height); // BMI formula
        }
    }

    // Method to determine the BMI status
    static void BMIStatus(double[,] team)
    {
        for (int i = 0; i < 10; i++)
        {
            double bmi = team[i, 2];
            if (bmi <= 18.4)
                Console.WriteLine($"Person {i + 1}: Underweight");
            else if (bmi <= 24.9)
                Console.WriteLine($"Person {i + 1}: Normal");
            else if (bmi <= 39.9)
                Console.WriteLine($"Person {i + 1}: Overweight");
            else
                Console.WriteLine($"Person {i + 1}: Obese");
        }
    }

    static void Main(string[] args)
    {
        double[,] team = new double[10, 3]; // Columns: 0 = Weight, 1 = Height, 2 = BMI

        // Input weight and height for each member
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");

            Console.Write("Weight (kg): ");
            team[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (cm): ");
            team[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate BMI for all team members
        CalculateBMI(team);

        // Display BMI status
        Console.WriteLine("\nBMI Status for Team Members:");
        BMIStatus(team);
    }
}
