using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100% Correctness 100% Performance 100% Task Score 100% Time Complexity O(N)

class Solution
{
    public int solution(int X, int[] A)
    {
        int len = A.Length;
        bool[] tracker = new bool[X + 1];
        tracker[0] = true;
        int uncovered = X; // tracks number of leaves that haven't been covered yet

        for (int i = 0; i < len; i++)
        {
            if (!tracker[A[i]]) // check if the leaf has already been added
            {
                tracker[A[i]] = true;
                uncovered--;
            }

            if (uncovered == 0) // all leaves covered
                return i;
        }

        return -1;
    }
}
