using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result Correctness 100% Performance 100% Time Complexity O(1)

class Solution
{
    public int solution(int X, int Y, int D)
    {
        if((double)Y- (double)X == 0d)
            return 0;
        return (int)Math.Ceiling((((double)Y - (double)X) / (double)D) + 0.5d);
    }
}
