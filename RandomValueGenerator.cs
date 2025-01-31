using System;

public class RandomValueGenerator
{
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); // 4-digit random number (1000 to 9999)
        }

        return randomNumbers;
    }

    // Method to find the average, minimum, and maximum value of an array
    public static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (var num in numbers)
        {
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        double average = sum / numbers.Length;

        return new double[] { average, min, max };
    }

    public static void Main(string[] args)
    {
        // Generate an array of 5 random 4-digit numbers
        int[] randomNumbers = Generate4DigitRandomArray(5);

        // Display the generated random numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (var num in randomNumbers)
        {
            Console.WriteLine(num);
        }

        // Find the average, min, and max values
        double[] results = FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine($"\nAverage Value: {results[0]:F2}");
        Console.WriteLine($"Minimum Value: {results[1]}");
        Console.WriteLine($"Maximum Value: {results[2]}");
    }
}
