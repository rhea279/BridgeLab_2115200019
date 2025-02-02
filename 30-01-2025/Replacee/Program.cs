using System;
class Replace
{
    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        // Replace old word with new word
        string modifiedSentence = sentence.Replace(oldWord, newWord);

        Console.WriteLine($"Modified Sentence: {modifiedSentence}");
    }
}
