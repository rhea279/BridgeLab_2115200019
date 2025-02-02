using System;
class Compare
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int minLength = Math.Min(str1.Length, str2.Length);

        // Compare character by character
        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                Console.WriteLine($"\"{str1}\" comes before \"{str2}\"");
                return;
            }
            else if (str1[i] > str2[i])
            {
                Console.WriteLine($"\"{str1}\" comes after \"{str2}\"");
                return;
            }
        }

        // If one string is a prefix of the other
        if (str1.Length < str2.Length)
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\"");
        else if (str1.Length > str2.Length)
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\"");
        else
            Console.WriteLine("Both strings are equal.");
    }
}
