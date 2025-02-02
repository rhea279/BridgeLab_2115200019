using System;
class Palindrome
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string reversed = "";

        // Reverse the string manually
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        // Compare original and reversed strings (case insensitive)
        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
}
