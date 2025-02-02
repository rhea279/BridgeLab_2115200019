using System;
class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        char[] toggledArray = new char[input.Length];

        // Iterate through the string and toggle case for each character
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
                toggledArray[i] = char.ToLower(input[i]);
            else if (char.IsLower(input[i]))
                toggledArray[i] = char.ToUpper(input[i]);
            else
                toggledArray[i] = input[i]; // Keep non-alphabetic characters unchanged
        }

        string toggledString = new string(toggledArray);
        Console.WriteLine($"Toggled String: {toggledString}");
    }
}
