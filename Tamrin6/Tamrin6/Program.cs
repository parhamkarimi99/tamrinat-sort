//Parham karimi
//Tamrin 6

using System;

class Program
{
    static int[] GetHardCodedArray()
    {
        int n = 1000;
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = (i % 10 == 0) ? 0 : (i * 3 + 5) % 50;
        return a;
    }

    static void MoveZeroesBuggy(int[] a)
    {
        int n = a.Length;
        int[] b = new int[n];
        int idx = n - 1;
        for (int i = 0; i < n; i++)
            if (a[i] != 0) b[idx--] = a[i];
        for (int i = 0; i < n; i++) a[i] = b[i];
    }

    static void Main()
    {
        int[] arr = GetHardCodedArray();
        MoveZeroesBuggy(arr);
    }
}