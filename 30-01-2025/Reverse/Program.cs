using System;
class Reverse
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string reversed = "";

        // Iterate through the string in reverse order and append characters to the new string
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        // Display the reversed string
        Console.WriteLine($"Reversed string: {reversed}");
    }
}
