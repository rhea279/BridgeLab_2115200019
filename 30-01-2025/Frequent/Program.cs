using System;
class Frequent
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Group characters and find the most frequent one
        char mostFrequent = input.GroupBy(c => c)
                                 .OrderByDescending(g => g.Count())
                                 .First()
                                 .Key;

        Console.WriteLine($"Most Frequent Character: '{mostFrequent}'");
    }
}
