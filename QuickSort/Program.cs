using System;

class Program
{
    static void Main()
    {
        int[] arr = { 6, 1, 5, 6, 7, 1, 3, 4, 9, 12, 32 };
        QuickSort(arr, 0, arr.Length - 1);

        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }

    static void QuickSort(int[] arr, int start, int end)
    {
        if (end <= start) return;

        int pivot = Partition(arr, start, end);

        QuickSort(arr, start, pivot - 1);
        QuickSort(arr, pivot + 1, end);
    }

    static int Partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int j = start - 1;

        for (int i = start; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
            {
                j++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        j++;
        int temp2 = arr[end];
        arr[end] = arr[j];
        arr[j] = temp2;

        return j;
    }
}