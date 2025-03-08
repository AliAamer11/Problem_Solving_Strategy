namespace MergeSort
{
    public static class Sort
    {
        public static int[] BubbleSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static void MergeSort(int[] array)
        {
            if (array.Length <= 1) return; // stop Condition
            int mid = array.Length / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[array.Length - mid]; // the reamin count because maybe the element count are odd

            int fullArrayIndex = 0;
            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[fullArrayIndex];
                fullArrayIndex++;
            }
            for (int j = 0; j < rightArray.Length; j++)
            {
                rightArray[j] = array[fullArrayIndex];
                fullArrayIndex++;
            }
            MergeSort(leftArray);
            MergeSort(rightArray);

            Merge(leftArray, rightArray, array);
        }

        private static void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int left = 0; int right = 0; int i = 0;
            while (left < leftSize && right < rightSize)
            {
                if (leftArray[left] < rightArray[right])
                {
                    array[i] = leftArray[left];
                    left++;
                }
                else
                {
                    array[i] = rightArray[right];
                    right++;
                }
                i++;
            }

            while (left < leftSize)
            {
                array[i] = leftArray[left];
                i++;
                left++;
            }

            while (right < rightSize)
            {
                array[i] = rightArray[right];
                i++;
                right++;
            }
        }
    }
}