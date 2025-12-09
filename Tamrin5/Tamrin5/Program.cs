//Parham karimi
//Tamrin 5

using System;
using System.Linq;

class Program
{
    static int[] GetNumbersToTest()
    {
        int n = 1000;
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = 1000 + i;
        return a;
    }

    static int[] Digits4(int x)
    {
        int[] d = new int[4];
        for (int i = 3; i >= 0; i--) { d[i] = x % 10; x /= 10; }
        return d;
    }

    static int FromDigits(int[] d)
    {
        int v = 0;
        for (int i = 0; i < d.Length; i++) v = v * 10 + d[i];
        return v;
    }

    static (bool reached, int[] path) KaprekarBuggy(int start)
    {
        int cur = start;
        int[] path = new int[10];
        int steps = 0;
        while (steps < 10)
        {
            path[steps++] = cur;
            int[] d = Digits4(cur);
            int[] asc = d.OrderBy(x => x).ToArray();
            int[] desc = d.OrderBy(x => x).ToArray();
            int small = FromDigits(asc);
            int big = FromDigits(desc);
            cur = big - small;
            if (cur == 6174) { path[steps++] = 6174; return (true, path.Take(steps).ToArray()); }
            if (cur == 0) break;
        }
        return (false, path.Take(steps).ToArray());
    }

    static void Main()
    {
        int[] tests = GetNumbersToTest();
        int printed = 0;
        foreach (int num in tests)
        {
            var res = KaprekarBuggy(num);
            printed++;
            if (printed > 20) break;
        }
    }
}