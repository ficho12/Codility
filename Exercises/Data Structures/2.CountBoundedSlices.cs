using System;
using System.Collections.Generic;

//Needs performance improvement (100% correctness, 60% performance)
class Solution {    
    public int solution(int K, int[] A) {
        int n = A.Length;
        int start = 0;
        int end = 0;
        int count = 0;
        int max = A[0];
        int min = A[0];
        
        while (end < n) {
            max = Math.Max(max, A[end]);
            min = Math.Min(min, A[end]);
            
            if (max - min <= K) {
                count += end - start + 1;
                end++;
            } else {
                start++;
                if (start > end) {
                    end = start;
                    max = A[start];
                    min = A[start];
                } else {
                    max = A[start];
                    min = A[start];
                    for (int i = start + 1; i <= end; i++) {
                        max = Math.Max(max, A[i]);
                        min = Math.Min(min, A[i]);
                    }
                }
            }
        }
        
        return count;
    }
}
