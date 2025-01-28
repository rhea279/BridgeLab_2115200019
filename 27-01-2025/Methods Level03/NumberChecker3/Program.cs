using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Task (a) - Count digits and store digits in an array
        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of digits: {digitCount}");

        int[] digitsArray = StoreDigitsInArray(number);
        Console.WriteLine("Digits in the number:");
        Console.WriteLine(string.Join(", ", digitsArray));

        // Task (b) - Reverse the digits array
        int[] reversedArray = ReverseArray(digitsArray);
        Console.WriteLine("Reversed digits array:");
        Console.WriteLine(string.Join(", ", reversedArray));

        // Task (c) - Compare two arrays
        Console.WriteLine("Are the original and reversed arrays equal?");
        bool areEqual = CompareArrays(digitsArray, reversedArray);
        Console.WriteLine(areEqual ? "Yes" : "No");

        // Task (d) - Check if the number is a palindrome
        bool isPalindrome = IsPalindrome(digitsArray);
        Console.WriteLine($"Is the number a palindrome? {isPalindrome}");

        // Task (e) - Check if the number is a duck number
        bool isDuck = IsDuck(digitsArray);
        Console.WriteLine($"Is the number a duck number? {isDuck}");
    }

    // (a) Method to count the number of digits in a number
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

    // (a) Method to store the digits of a number in an array
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

    // (b) Method to reverse the digits array
    static int[] ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversed[i] = array[array.Length - 1 - i];
        }
        return reversed;
    }

    // (c) Method to compare two arrays
    static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
        return true;
    }

    // (d) Method to check if a number is a palindrome using the digits
    static bool IsPalindrome(int[] digitsArray)
    {
        int[] reversedArray = ReverseArray(digitsArray);
        return CompareArrays(digitsArray, reversedArray);
    }

    // (e) Method to check if a number is a duck number using the digits array
    static bool IsDuck(int[] digitsArray)
    {
        bool hasNonZeroStarted = false;
        foreach (int digit in digitsArray)
        {
            if (digit != 0)
            {
                hasNonZeroStarted = true;
            }
            else if (hasNonZeroStarted)
            {
                return true; // A '0' found after a non-zero digit
            }
        }
        return false; // No '0' found after the first non-zero digit
    }
}
