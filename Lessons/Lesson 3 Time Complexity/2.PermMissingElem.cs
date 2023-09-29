using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result 100% Correctness 100% Performance 100% Time Complexity O(N) or O(N * log(N))

class Solution
{
    public int solution(int[] A)
    {
        int len = A.Length;
        bool[] tracker = new bool[len + 2];

        for (int i = 0; i < len; i++)
        {
            tracker[A[i]] = true;
        }

        for (int i = 1; i < tracker.Length; i++)
        {
            if (!tracker[i])
                return i;
        }
        return 1;
    }
}