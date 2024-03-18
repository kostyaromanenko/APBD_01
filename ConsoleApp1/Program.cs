
class Program
{
    public static double CalculateAverage(int[] numbers)
    {
        int i = 0;
        foreach (int number in numbers)
        {
            i += number;
        }
        
        return (double)i / numbers.Length;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");
    }
}