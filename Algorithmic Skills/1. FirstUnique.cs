using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Dictionary<int, int> count = new Dictionary<int, int>();

        for (int i = 0; i < A.Length; i++) {
            if (count.ContainsKey(A[i])) 
                count[A[i]]++;
            else 
                count[A[i]] = 1;
        }

        for (int i = 0; i < A.Length; i++) {
            if (count[A[i]] == 1)
                return A[i];
        }

        return -1;
    }
}
