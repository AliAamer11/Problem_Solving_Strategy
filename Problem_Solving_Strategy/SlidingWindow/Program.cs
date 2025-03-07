namespace SlidingWindow
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 22, 300, 44, 423, 9, 123, 11, 200, 188, 14, 15, 22, 57, 77 };
            int windowSize = 3;
            //Console.WriteLine($"MaxSumWithPureForce is {MaxSumWithPureForce(numbers, windowSize)}");
            Console.WriteLine($"MaxSumWithPureForce is {MaxSumWithSlidingWindow(numbers, windowSize)}");
        }
        static int MaxSumWithSlidingWindow(int[] source, int windowSize)
        {
            int maxSum = -1;
            int windowSum = 0;

            for (int i = 0; i < windowSize; i++)
            {
                windowSum += source[i];
            }
            maxSum = windowSum;

            for (int i = windowSize; i < source.Length; i++)
            {
                windowSum += source[i] - source[i - windowSize];
                maxSum = Math.Max(maxSum, windowSum);
            }
            return maxSum;

        }
        static int MaxSumWithPureForce(int[] source, int windowSize)
        {
            int maxSum = -1;

            for (int i = 0; i <= source.Length - windowSize; i++)
            {
                int windowSum = 0;
                for (int j = i; j < i + windowSize; j++)
                {
                    windowSum += source[j];
                }
                maxSum = Math.Max(maxSum, windowSum);
            }
            return maxSum;
        }

    }
}
