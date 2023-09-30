using System;
// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

// Result 100% Correctness 100% Performance 100% Task Score 100% Time Complexity O(N*log(N))

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A);
        if (A.Length < 3)
            return 0;
        else if ((A[A.Length - 1] == int.MaxValue && A[A.Length - 2] == int.MaxValue && A[A.Length - 3] == int.MaxValue))
            return 1;
        for (int i = 0; i < A.Length - 2; i++)
        {
            if (A[i] + A[i + 1] > A[i + 2])
                return 1;
        }
        return 0;
    }
}
