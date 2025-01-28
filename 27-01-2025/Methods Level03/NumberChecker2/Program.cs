using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of digits: {digitCount}");

        int[] digitsArray = StoreDigitsInArray(number);
        Console.WriteLine("Digits in the number:");
        Console.WriteLine(string.Join(", ", digitsArray));

        int sumOfDigits = SumOfDigits(digitsArray);
        Console.WriteLine($"Sum of digits: {sumOfDigits}");

        int sumOfSquares = SumOfSquaresOfDigits(digitsArray);
        Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");

        if (IsHarshadNumber(number, sumOfDigits))
        {
            Console.WriteLine($"{number} is a Harshad number.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a Harshad number.");
        }

        int[,] digitFrequency = FindDigitFrequency(digitsArray);
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < digitFrequency.GetLength(0); i++)
        {
            Console.WriteLine($"Digit: {digitFrequency[i, 0]}, Frequency: {digitFrequency[i, 1]}");
        }
    }

    // Method to count the number of digits in a number
    static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    // Method to store the digits of a number in an array
    static int[] StoreDigitsInArray(int number)
    {
        int size = CountDigits(number);
        int[] digits = new int[size];
        for (int i = size - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Method to find the sum of digits in a number
    static int SumOfDigits(int[] digitsArray)
    {
        int sum = 0;
        foreach (int digit in digitsArray)
        {
            sum += digit;
        }
        return sum;
    }

    // Method to find the sum of the squares of digits in a number
    static int SumOfSquaresOfDigits(int[] digitsArray)
    {
        int sum = 0;
        foreach (int digit in digitsArray)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    // Method to check if a number is a Harshad number
    static bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }

    // Method to find the frequency of each digit in the number
    static int[,] FindDigitFrequency(int[] digitsArray)
    {
        int[,] frequency = new int[10, 2]; // Array to store digit and its frequency
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; // Initialize digit
            frequency[i, 1] = 0; // Initialize frequency
        }

        foreach (int digit in digitsArray)
        {
            frequency[digit, 1]++;
        }

        int nonZeroCount = 0;
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                nonZeroCount++;
            }
        }

        int[,] result = new int[nonZeroCount, 2];
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                result[index, 0] = frequency[i, 0];
                result[index, 1] = frequency[i, 1];
                index++;
            }
        }

        return result;
    }
}
