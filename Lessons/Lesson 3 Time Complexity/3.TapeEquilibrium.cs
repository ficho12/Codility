using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result 100% Correctness 100% Performance 100% Time Complexity O(N)

class Solution
{
    public int solution(int[] A)
    {
        int[] sum = new int[A.Length];
        int[] sumRev = new int[A.Length];
        int[] rev = new int[A.Length];
        Array.Copy(A, rev, A.Length);
        int min = int.MaxValue;
        int j = A.Length;
        Array.Reverse(rev);

        sum[0] = A[0];
        sumRev[0] = rev[0];
        //Console.WriteLine("Sum[" + 0 + "]=" + sum[0] + "\tsumRev[" + 0 + "]=" + sumRev[0]);

        for (int i = 1; i < A.Length; i++)
        {
            sum[i] = sum[i - 1] + A[i];
            sumRev[i] = sumRev[i - 1] + rev[i];

            //Console.WriteLine("Sum[" + i + "]=" + sum[i] + "\tsumRev[" + i + "]=" + sumRev[i]);
        }

        for (int i = 0; i < A.Length - 1; i++)
        {
            if (Math.Abs(sum[i] - sumRev[j - 2]) < min)
                min = Math.Abs(sum[i] - sumRev[j - 2]);
            //Console.WriteLine("|" + sum[i] + " - " + sumRev[j - 2] + "| = " + Math.Abs(sum[i] - sumRev[j - 2]));
            j--;
        }

        return min;
    }
}