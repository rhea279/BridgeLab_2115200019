using System;
class Substring
{
    static void Main()
    {
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();
        Console.Write("Enter the substring to count: ");
        string subString = Console.ReadLine();

        int count = 0, index = 0;

        // Loop through the main string to find occurrences of the substring
        while ((index = mainString.IndexOf(subString, index)) != -1)
        {
            count++;
            index += subString.Length; // Move index forward
        }

        Console.WriteLine($"Occurrences of '{subString}': {count}");
    }
}
