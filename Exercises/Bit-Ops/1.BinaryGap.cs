using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Results: 100% Correctness, Performance: Not assessed

// See Lesson 1 - Iterations - BinaryGap (Repeated exercise) 

class Solution {
    public int solution(int N) {
        //Convert N to binary
        string binary = Convert.ToString(N, 2);
        int len = binary.Length;
        int maxGap = 0, currentGap = 0;

        for (int i = 0; i < len; i++)
        {
            if (binary[i] == '1')
            {
                if(currentGap>=maxGap)
                    maxGap = currentGap;
                currentGap = 0;
            }
            else
            {
                currentGap++;
            }
        }
        return maxGap;
    }
}
