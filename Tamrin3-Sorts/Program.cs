//Parham karimi
//Tamrin 3

class Program
{
    static int[] GetArray()
    {
        int n = 1000;
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = (i * 37 + 17) % 1000;
        return a;
    }

    static void PrintFirstTen(int[] a)
    {
        Console.Write("First10: ");
        for (int i = 0; i < 10; i++) Console.Write(a[i] + " ");
        Console.WriteLine();
    }

    static void BubbleSort(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - 1 - i; j++)
                if (a[j] > a[j + 1])
                {
                    int t = a[j]; a[j] = a[j + 1]; a[j + 1] = t;
                }
    }

    static void SelectionSort(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++) if (a[j] < a[min]) min = j;
            int tmp = a[i]; a[i] = a[min]; a[min] = tmp;
        }
    }

    static int[] MergeSortNaive(int[] a)
    {
        int n = a.Length;
        int[] arr = new int[n];
        Array.Copy(a, arr, n);

        for (int size = 1; size < n; size *= 2)
        {
            int[] tmp = new int[n];
            int k = 0;
            for (int start = 0; start < n; start += 2 * size)
            {
                int mid = Math.Min(start + size, n);
                int end = Math.Min(start + 2 * size, n);
                int i = start, j = mid;
                while (i < mid && j < end)
                    if (arr[i] <= arr[j]) tmp[k++] = arr[i++];
                    else tmp[k++] = arr[j++];
                while (i < mid) tmp[k++] = arr[i++];
                while (j < end) tmp[k++] = arr[j++];
            }
            Array.Copy(tmp, arr, n);
        }
        return arr;
    }

    static void Main()
    {
        int[] arr = GetArray();
        PrintFirstTen(arr);

        int[] b1 = (int[])arr.Clone();
        BubbleSort(b1);
        PrintFirstTen(b1);

        int[] b2 = (int[])arr.Clone();
        SelectionSort(b2);
        PrintFirstTen(b2);

        int[] b3 = MergeSortNaive(arr);
        PrintFirstTen(b3);
        Console.ReadKey();
    }
}
