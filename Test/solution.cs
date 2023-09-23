using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int n = A.Length;
        bool[] present = new bool[n + 1];

        for (int i = 0; i < n; i++) {
            if (A[i] > 0 && A[i] <= n) {
                present[A[i]] = true;
            }
        }

        for (int i = 1; i <= n; i++) {
            if (!present[i]) {
                return i;
            }
        }

        return n + 1;
    }
}
