using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int i=0;
        int nextIndex = 0;
        while(true)
        {
            nextIndex = A[nextIndex];
            i++;
            
            if(nextIndex == -1)
                return i;
        }
    }
}
