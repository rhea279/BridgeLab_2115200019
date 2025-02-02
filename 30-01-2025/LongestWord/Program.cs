using System;
class LongestWord
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' '); // Split sentence into words
        string longestWord = "";

        // Iterate through each word and find the longest one
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
                longestWord = word;
        }

        // Display the longest word
        Console.WriteLine($"The longest word is: {longestWord}");
    }
}
