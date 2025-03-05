namespace DivideAndConquer;
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = [1, 3, 5, 6, 8, 12, 15, 22, 27, 32, 36, 39, 41, 45, 49, 55, 61, 67, 74, 79, 86];

        var indexIteretaivly = BinarySearch.Iteretaivly(numbers, 67);
        Console.WriteLine(indexIteretaivly);

        var indexRecursively = BinarySearch.Recursively(numbers, 67, 0, numbers.Length - 1);
        Console.WriteLine(indexRecursively);

        Console.ReadKey();
    }
}
