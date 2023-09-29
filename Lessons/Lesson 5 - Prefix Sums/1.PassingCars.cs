using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//Result 100% Correctness 100% Performance 100% Time Complexity O(N)

class Solution
{
    public int solution(int[] A)
    {
        int cars = 0;
        int len = A.Length;
        int num1 = 0;
        for (int i = len - 1; i >= 0; i--)
        {
            if (cars > 1000000000)
                return -1;

            if (A[i] == 1)
            {
                num1++;
            }
            else
            {
                cars += num1;
            }
        }

        return cars;
    }
}
