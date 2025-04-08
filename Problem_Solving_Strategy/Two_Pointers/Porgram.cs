using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Pointers
{
    public class Porgram
    {
        static void Main(string[] args)
        {
            int[] heights = [1, 8, 6, 2, 5, 4, 8, 3, 7];

            Console.WriteLine("BruteForce");
            Console.WriteLine(GetMaxContainerAreaByBruteForce(heights));

            Console.WriteLine("Tow-Pointer");
            Console.WriteLine(GetMaxContainerAreaByTowPointer(heights));

        }
        static int GetMaxContainerAreaByBruteForce(int[] heights)
        {
            int maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = i + 1; j < heights.Length; j++)
                {
                    int currentArea = Math.Min(heights[i], heights[j]) * (j - 1);
                    maxArea = Math.Max(maxArea, currentArea);
                }
            }
            return maxArea;
        }
        static int GetMaxContainerAreaByTowPointer(int[] heights)
        {
            int left = 0;
            int right = heights.Length - 1;
            int maxArea = 0;


            while (left < right)
            {
                int currentArea = Math.Min(heights[left], heights[right]) * (right - left);
                maxArea = Math.Max(maxArea, currentArea);
                if (heights[left]< heights[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}
