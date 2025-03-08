using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Porgram
    {
        static void Main(string[] args)
        {
            int[] bubbleNumbers = { 1, 2, 3, 4, 5, 22, 300, 44, 423, 9, 123, 11, 200, 188, 14, 15, 22, 57, 77 };

            bubbleNumbers = Sort.BubbleSort(bubbleNumbers);
            Console.WriteLine("Bubble Sort");
            foreach (var number in bubbleNumbers)
            {
                Console.Write($"{number}  ");
            }
            Console.WriteLine();
            Console.WriteLine("Merge Sort");
            int[] mergeNumbers = { 1, 2, 3, 4, 5, 22, 300, 44, 423, 9, 123, 11, 200, 188, 14, 15, 22, 57, 77 };
            Sort.MergeSort(mergeNumbers);
            foreach (var number in mergeNumbers)
            {
                Console.Write($"{number}  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
