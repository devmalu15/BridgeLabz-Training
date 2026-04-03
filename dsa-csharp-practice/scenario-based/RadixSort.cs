using System;

class RadixSort
{
    public static void Sort(long[] arr)
    {
        long max = GetMax(arr);

        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountSort(arr, exp);
        }
    }

    private static void CountSort(long[] arr, long exp)
    {
        int n = arr.Length;
        long[] output = new long[n];
        int[] count = new int[10];

        for (int i = 0; i < 10; i++)
            count[i] = 0;

        for (int i = 0; i < n; i++)
            count[(int)((arr[i] / exp) % 10)]++;

        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((arr[i] / exp) % 10);
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    private static long GetMax(long[] arr)
    {
        long max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    public static void Main(String[] args)
    {
        long[] arr = { 
            123456789012, 
            987654321098, 
            100000000001, 
            555555555555, 
            123456789011, 
            999999999999 
        };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        Sort(arr);

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);
    }

    private static void PrintArray(long[] arr)
    {
        foreach (long val in arr)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}