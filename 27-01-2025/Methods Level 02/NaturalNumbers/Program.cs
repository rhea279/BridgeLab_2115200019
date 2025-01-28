using System;

class NaturalNumbers
{
    static void Main(string[] args)
    {
        //Input a number from user
        Console.WriteLine("Input a number:");

        // Validate if the input is a non-negative integer
        if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
        {
            Console.WriteLine("Invalid Number added. Try Again.");
            return;
        }

        // Display the sum of natural numbers calculated using recursion
        Console.WriteLine($"Sum of {number} natural numbers using recursion is {SumNaturalRecursion(number)}");

        // Display the sum of natural numbers calculated using the formula
        Console.WriteLine($"Sum of {number} natural numbers using formula is {SumNaturalFormula(number)}");
    }

    // Method to calculate the sum of n natural numbers using recursion
    static int SumNaturalRecursion(int n)
    {
        // Base case: if n is 1, return 1
        if (n == 1)
        {
            return 1;
        }

        // Recursive case: add n to the sum of (n-1) natural numbers
        return n + SumNaturalRecursion(n - 1);
    }

    // Method to calculate the sum of n natural numbers using the formula
    static int SumNaturalFormula(int n)
    {
        // Use the formula: n * (n + 1) / 2
        int sum = n * (n + 1) / 2;
        return sum;
    }
}
