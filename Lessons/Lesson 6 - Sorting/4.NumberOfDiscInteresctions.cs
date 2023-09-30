using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result 100% Correctness 87% Performance 50% Task Score 68% Time Complexity O(N**2)


class Solution
{
    public int solution(int[] A)
    {
        int len = A.Length;
        int intersec = 0;
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                if (A[i] + A[j] >= j - i)
                {
                    intersec++;
                    if(intersec > 10000000)
                        return -1;
                }
            }
        }
        return intersec;
    }
}