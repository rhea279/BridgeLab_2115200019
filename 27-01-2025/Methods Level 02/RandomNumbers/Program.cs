using System;

class RandomValues
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        int[] randomNumbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); // Generate 4-digit random numbers (1000 to 9999)
        }
        return randomNumbers;
    }

    // Method to find the average, min, and max values of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }

        double average = sum / (double)numbers.Length;
        return new double[] { average, min, max };
    }

    static void Main(string[] args)
    {
        RandomValues randomValues = new RandomValues();

        // Generate an array of 5 random 4-digit numbers
        int[] randomNumbers = randomValues.Generate4DigitRandomArray(5);

        // Display the generated numbers
        Console.WriteLine("Generated Random Numbers:");
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }

        // Find the average, min, and max
        double[] results = randomValues.FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine($"\nAverage: {results[0]:F2}");
        Console.WriteLine($"Minimum: {results[1]}");
        Console.WriteLine($"Maximum: {results[2]}");
    }
}
