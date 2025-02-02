using System;
class SpecificChar
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadLine()[0];

        // Remove the character using Replace method
        string result = input.Replace(charToRemove.ToString(), "");

        Console.WriteLine($"Modified String: {result}");
    }
}
