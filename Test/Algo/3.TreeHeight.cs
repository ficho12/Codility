using System;

class Solution {
    public int solution(Tree T) {
        if (T == null)
            return -1;
        else 
            return 1 + Math.Max(solution(T.l), solution(T.r));
    }
}