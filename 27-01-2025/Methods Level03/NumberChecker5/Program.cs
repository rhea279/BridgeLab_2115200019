using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int n)
    {
        int[] factors = new int[n];
        int count = 0;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                factors[count] = i;
                count++;
            }
        }

        Array.Resize(ref factors, count);
        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int GreatestFactor(int n)
    {
        int[] factors = FindFactors(n);
        return factors[factors.Length - 1];
    }

    // Method to find the sum of the factors using factors array and return the sum
    public static int SumOfFactors(int n)
    {
        int[] factors = FindFactors(n);
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using factors array and return the product
    public static int ProductOfFactors(int n)
    {
        int[] factors = FindFactors(n);
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cubes of the factors using factors array
    public static double ProductOfCubesOfFactors(int n)
    {
        int[] factors = FindFactors(n);
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int n)
    {
        int sum = SumOfFactors(n);
        return sum == n;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int n)
    {
        int sum = SumOfFactors(n);
        return sum > n;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int n)
    {
        int sum = SumOfFactors(n);
        return sum < n;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int n)
    {
        int originalNumber = n;
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += Factorial(digit);
            n /= 10;
        }

        return sum == originalNumber;
    }

    // Helper method to calculate factorial of a number
    private static int Factorial(int num)
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
		Console.Write("Enter a number :");
        int number = Convert.ToInt32(Console.ReadLine());

        // Finding Factors
        int[] factors = NumberChecker.FindFactors(number);
        Console.WriteLine($"Factors of {number}: {string.Join(", ", factors)}");

        // Greatest Factor
        int greatestFactor = NumberChecker.GreatestFactor(number);
        Console.WriteLine($"Greatest Factor of {number}: {greatestFactor}");

        // Sum of Factors
        int sumFactors = NumberChecker.SumOfFactors(number);
        Console.WriteLine($"Sum of Factors of {number}: {sumFactors}");

        // Product of Factors
        int productFactors = NumberChecker.ProductOfFactors(number);
        Console.WriteLine($"Product of Factors of {number}: {productFactors}");

        // Product of Cubes of Factors
        double productCubes = NumberChecker.ProductOfCubesOfFactors(number);
        Console.WriteLine($"Product of Cubes of Factors of {number}: {productCubes}");

        // Perfect Number Check
        bool isPerfect = NumberChecker.IsPerfectNumber(number);
        Console.WriteLine($"{number} is a Perfect Number: {isPerfect}");

        // Abundant Number Check
        bool isAbundant = NumberChecker.IsAbundantNumber(number);
        Console.WriteLine($"{number} is an Abundant Number: {isAbundant}");

        // Deficient Number Check
        bool isDeficient = NumberChecker.IsDeficientNumber(number);
        Console.WriteLine($"{number} is a Deficient Number: {isDeficient}");

        // Strong Number Check
        bool isStrong = NumberChecker.IsStrongNumber(number);
        Console.WriteLine($"{number} is a Strong Number: {isStrong}");
    }
}
