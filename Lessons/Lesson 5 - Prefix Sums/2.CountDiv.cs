using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 50% Correctness 100% Performance 0% Time Complexity O(B-A)

class Solution
{
    public int solution(int A, int B, int K)
    {
        int count;
        for(int i = A; i<=B; i++)
        {
            if(i%K == 0)
               count++; 
        }
        return count;
    }
}
