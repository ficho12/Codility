using System;

// Result 100% Correctness 100% Performance 100% Task Score 100% Time Complexity O(N*log(N))

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);
        int len = A.Length;
        int max = A[len - 1] * A[len - 2] * A[len - 3];
        int max2 = A[0] * A[1] * A[len - 1];
        return max > max2 ? max : max2;
    }
}
