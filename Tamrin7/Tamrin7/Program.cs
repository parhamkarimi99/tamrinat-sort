//Parham karimi
//Tamrin 7

using System;

class Program
{
    static int[] GetHardCodedArray()
    {
        int n = 1000;
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = (i * 5 + 11) % 200;
        return a;
    }

    static void RotateOffByOne(int[] a, int k)
    {
        int n = a.Length;
        k = k % n;
        for (int step = 0; step < k; step++)
        {
            int last = a[n - 1];
            for (int i = n - 1; i >= 2; i--) a[i] = a[i - 1];
            a[0] = last;
        }
    }

    static void Main()
    {
        int[] arr = GetHardCodedArray();
        int k = 3;
        RotateOffByOne(arr, k);
    }
}