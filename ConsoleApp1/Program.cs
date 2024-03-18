class Program
{
    public static int FindMaximumValue(int[] numbers)
    {
        int maxValue = numbers[0]; 
        foreach (int number in numbers) {
            if (number > maxValue) {
                maxValue = number;
            }
        }
        return maxValue;
    }

    static void Main(string[] args) {
        int[] numbers = { 5, 3, 9, 1, 6 };
        int max = FindMaximumValue(numbers);
        Console.WriteLine($"The maximum value is: {max}");
    }
}