namespace DivideAndConquer;
public static class BinarySearch
{

    public static int Iteretaivly(int[] source, int target)
    {
        int left = 0;
        int right = source.Length - 1;

        while (left <= right)
        {
            //int mid = (left + right) / 2; // this causing over flow
            int mid = left + ((right - left) / 2);
            if (target == source[mid])
                return mid;
            else if (target > source[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    public static int Recursively(int[] source, int target, int left, int right)
    {
        if (left > right)
            return -1;

        int mid = left + ((right - left) / 2);

        if (target == source[mid])
            return mid;
        else if (target > source[mid])
            return Recursively(source, target, mid + 1, right);
        else
            return Recursively(source, target, left, mid - 1);
    }
}
