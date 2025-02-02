using System;
class Count
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower(); // Convert input to lowercase for easy comparison
        int vowels = 0, consonants = 0;

        // Iterate through each character in the string
        foreach (char c in input)
        {
            if (char.IsLetter(c)) // Check if the character is a letter
            {
                if ("aeiou".Contains(c)) // Check if it is a vowel
                    vowels++;
                else
                    consonants++; // Otherwise, it's a consonant
            }
        }

        // Display the result
        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }
}
