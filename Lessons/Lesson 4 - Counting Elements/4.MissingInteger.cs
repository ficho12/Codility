using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        int smallest = 0;
        if (A.Max() <= 0)
            return 1;

        bool[] bools = new bool[A.Max() + 1];
        bools[0] = true;
        foreach (int i in A)
        {
            if (i > 0)
                bools[i] = true;
        }

        foreach (bool b in bools)
        {
            if (!b)
                return smallest;
            smallest++;
        }

        return smallest;
    }
}