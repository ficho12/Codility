using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int[] solution(int N, int[] A)
    {
        int []counters = new int = [0,0,0,0,0];

        for (int K = 0; i < A.Length; K++)
        {
            if (1<=A[K]<=N)
            {
                counters[A[K]]++;
            }else if (A[K] == N+1)
            {
                Array.fill(counters, counters.Max());
            }
        }
        return counters;
    }
}
