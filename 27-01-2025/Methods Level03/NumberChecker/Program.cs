using System;

class NumberChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int digitCount = CountDigits(number);
        Console.WriteLine($"Number of digits: {digitCount}");

        int[] digits = StoreInArray(number);

        Console.WriteLine("Digits in the array:");
        Console.WriteLine(string.Join(", ", digits));

        if (IsDuck(digits))
        {
            Console.WriteLine($"{number} is a Duck Number.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a Duck Number.");
        }

        if (IsArmstrong(digits))
        {
            Console.WriteLine($"{number} is an Armstrong Number.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT an Armstrong Number.");
        }

        FindLargestAndSecondLargest(digits, out int largest, out int secondLargest);
        Console.WriteLine($"Largest digit: {largest}, Second Largest digit: {secondLargest}");

        FindSmallestAndSecondSmallest(digits, out int smallest, out int secondSmallest);
        Console.WriteLine($"Smallest digit: {smallest}, Second Smallest digit: {secondSmallest}");
    }

    static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10; // Fix: changed 'n' to 'number'
        }
        return count;
    }

    static int[] StoreInArray(int number)
    {
        int size = CountDigits(number);
        int[] array = new int[size];
        for (int i = size - 1; i >= 0; i--)
        {
            array[i] = number % 10;
            number /= 10;
        }
        return array;
    }

    static bool IsDuck(int[] array)
    {
        bool hasNonZeroStarted = false; // To track if non-zero has started
        foreach (int digit in array) // Fix: changed 'number' to 'array'
        {
            if (digit != 0)
            {
                hasNonZeroStarted = true; // Non-zero digit found
            }
            else if (hasNonZeroStarted)
            {
                return true; // '0' found after a non-zero digit
            }
        }
        return false; // No '0' found after non-zero digits
    }

    static bool IsArmstrong(int[] array)
    {
        int sum = 0;
        int length = array.Length; // Fix: added 'length' variable
        for (int i = 0; i < array.Length; i++)
        {
            sum += (int)Math.Pow(array[i], length); // Fix: cast Math.Pow to int
        }

        int number = 0;
        for (int i = 0; i < length; i++)
        {
            number = number * 10 + array[i];
        }

        return sum == number; // Check if the sum is equal to the original number
    }

    static void FindLargestAndSecondLargest(int[] array, out int largest, out int secondLargest)
    {
        largest = Int32.MinValue;
        secondLargest = Int32.MinValue;

        foreach (int num in array)
        {
            if (num > largest)
            {
                secondLargest = largest; // Update second largest
                largest = num;           // Update largest
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num; // Update second largest
            }
        }
    }

    static void FindSmallestAndSecondSmallest(int[] array, out int smallest, out int secondSmallest)
    {
        smallest = Int32.MaxValue;
        secondSmallest = Int32.MaxValue;

        foreach (int num in array)
        {
            if (num < smallest)
            {
                secondSmallest = smallest; // Update second smallest
                smallest = num;            // Update smallest
            }
            else if (num < secondSmallest && num != smallest)
            {
                secondSmallest = num; // Update second smallest
            }
        }
    }
}
