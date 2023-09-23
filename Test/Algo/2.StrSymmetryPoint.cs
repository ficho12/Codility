using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        int n = S.Length;

        for (int i = 0; i < n / 2; i++) {
            if (S[i] != S[n - i - 1])
                return -1;
        }

        if (n % 2 == 0)
            return -1;
        else 
            return n / 2;
    }  
}
