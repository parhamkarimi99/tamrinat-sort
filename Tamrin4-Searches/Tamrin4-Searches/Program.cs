//Parham karimi
//Tamrin 4

using System;

class Program
{
    static int[] GetArray()
    {
        int[] a = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            int x = 0;
            for (int j = 0; j < i; j++) x += 13;
            x += 7;
            while (x >= 1000) x -= 1000;
            a[i] = x;
        }
        return a;
    }

    static void PrintIndex(string name, int idx)
    {
        Console.WriteLine(name + ": " + idx);
    }

    static int LinearSearch(int[] a, int target)
    {
        for (int i = 0; i < a.Length; i++)
            if (a[i] == target) return i;
        return -1;
    }

    static void SelectionSort(int[] a)
    {
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++)
                if (a[j] < a[min]) min = j;
            int tmp = a[i]; a[i] = a[min]; a[min] = tmp;
        }
    }

    static int BinarySearch(int[] a, int target)
    {
        int l = 0, r = a.Length - 1;
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (a[m] == target) return m;
            else if (a[m] < target) l = m + 1;
            else r = m - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = GetArray();
        int target = 500;

        int p1 = LinearSearch(arr, target);
        PrintIndex("LinearSearch", p1);

        int[] arr2 = new int[1000];
        for (int i = 0; i < 1000; i++) arr2[i] = arr[i];
        SelectionSort(arr2);

        int p2 = BinarySearch(arr2, target);
        PrintIndex("BinarySearch", p2);
        Console.ReadKey();
    }   
}
