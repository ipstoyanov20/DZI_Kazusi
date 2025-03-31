using System;
using System.Globalization;

class SquareRoot
{
    private static int max = 1000;
    private static double[] values;
    
    static SquareRoot()
    {
        values = new double[max + 1];
        for (int i = 1; i <= max; i++) values[i] = Math.Sqrt(i);
    }

    public static double Sqrt(int value)
    {
        return values[value];
    }
}

public class Tema3
{
    public void Run()
    {
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];

        // Fix: Store values in correct order
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers[i] = SquareRoot.Sqrt(number);
        }

        // Print results correctly
        foreach (var num in numbers)
        {
            Console.WriteLine(num.ToString("G15", CultureInfo.InvariantCulture));
        }
    }
}