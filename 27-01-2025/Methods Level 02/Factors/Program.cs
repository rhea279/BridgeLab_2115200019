using System;

class Factors
{
    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the method to find factors and store them in an array
        int[] factors = FindFactor(number);

        // Display the results
        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine("Sum of factors: " + SumFactors(factors));
        Console.WriteLine("Product of factors: " + ProductFactors(factors));
        Console.WriteLine("Sum of squares of factors: " + SumOfSquaresOfFactor(factors));
    }

    // Method to find all factors of a given number
    static int[] FindFactor(int n)
    {
        int count = 0;

        // First loop to count the number of factors
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        // Initialize the array with the count of factors
        int[] factors = new int[count];
        int index = 0;

        // Second loop to populate the array with factors
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to calculate the sum of factors
    static int SumFactors(int[] factors)
    {
        int sum = 0;

        // Iterate through the array and sum up the factors
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }

        return sum;
    }

    // Method to calculate the product of factors
    static int ProductFactors(int[] factors)
    {
        int product = 1; // Start with 1 since it's a multiplication

        // Iterate through the array and multiply the factors
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }

        return product;
    }

    // Method to calculate the sum of squares of factors
    static double SumOfSquaresOfFactor(int[] factors)
    {
        double sqSum = 0; // Use double for precision since Math.Pow returns double

        // Iterate through the array and add the square of each factor
        for (int i = 0; i < factors.Length; i++)
        {
            sqSum += Math.Pow(factors[i], 2);
        }

        return sqSum;
    }
}
