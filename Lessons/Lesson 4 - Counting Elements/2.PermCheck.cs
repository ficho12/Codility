using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100% Correctness 100% Performance 100% Task Score 100% Time Complexity O(N)

class Solution
{
    public int solution(int[] A)
    {
        bool[] bools = new bool[A.Length];

        foreach (int i in A)
        {
            if(i>A.Length)
               return 0;
            bools[i-1] = true;
        }

        return bools.All(x => x) ? 1 : 0;
    }
}
