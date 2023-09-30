using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result 100% Correctness 100% Performance 100% Task Score 100% Time Complexity O(N*log(N)) or O(N)

class Solution
{
    public int solution(int[] A)
    {
        return A.Distinct().Count();
    }
}
