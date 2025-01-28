using System;

class Numbers
{
    // Method to check whether the number is positive, negative, or zero
    static bool isPositive(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"Number {number} is Positive");
            return true;
        }
        else if (number < 0)
        {
            Console.WriteLine($"Number {number} is Negative");
            return false;
        }
        else
        {
            Console.WriteLine($"Number {number} is Zero");
            return false;
        }
    }

    // Method to check whether the number is even or odd
    static void isEven(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"Number {number} is Even");
        }
        else
        {
            Console.WriteLine($"Number {number} is Odd");
        }
    }

    // Method to compare two numbers and return 1 if n1 > n2, 0 if equal, or -1 if n1 < n2
    static int Compare(int n1, int n2)
    {
        if (n1 > n2)
        {
            Console.WriteLine($"Number {n1} is greater than {n2}");
            return 1;
        }
        else if (n1 == n2)
        {
            Console.WriteLine($"Number {n1} is equal to {n2}");
            return 0;
        }
        else
        {
            Console.WriteLine($"Number {n1} is less than {n2}");
            return -1;
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (isPositive(numbers[i]))
            {
                isEven(numbers[i]);
            }
        }

        // compare the first and last element of the array by calling the method compare() and display if they are equal, greater, or less 
        Compare(numbers[0], numbers[4]);
    }
}
