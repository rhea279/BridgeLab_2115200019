using System;
class Anagrams
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Check if sorted characters of both strings are equal
        bool isAnagram = str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c));

        if (isAnagram)
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }
}
