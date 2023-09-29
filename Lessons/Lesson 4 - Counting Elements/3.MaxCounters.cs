using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result 100% Correctness 100% Performance 40% Task Score 66% Time Complexity O(N + M)

class Solution
{
    public int[] solution(int N, int[] A)
    {
        int[] counters = new int[N];
        Array.Fill(counters, 0);

        int len = A.Length;


        for (int K = 0; K < len; K++)
        {
            if ((1 <= A[K]) && (A[K] <= N))
            {
                counters[A[K] - 1] += 1;
                //Console.WriteLine("Entrando en if. K: " + K +", "+ counters[A[K]-1]);
                //Console.WriteLine(counters.ToString());
            }
            else //if (A[K] == N+1)
            {
                Array.Fill(counters, counters.Max());
            }
            //Console.WriteLine("("+counters[0]+", "+counters[1]+", "+counters[2]+", "+counters[3]+", "+counters[4]+")");
        }
        return counters;
    }
}