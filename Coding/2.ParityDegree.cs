using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        int highestPowerOf2 = 0;

        while (N % 2 == 0) {
            N /= 2;
            highestPowerOf2++;
        }

        return highestPowerOf2;
    }
}
