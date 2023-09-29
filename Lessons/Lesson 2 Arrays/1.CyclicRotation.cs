using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result: 100% Correctness, Performance Not assessed

class Solution
{
    public int[] solution(int[] A, int K)
    {
        int N = A.Length;

        if (N == 0 || K % N == 0)
        {
            // If the array is empty or K is a multiple of N, no rotation is needed
            return A;
        }

        int[] rotated = new int[N];

        for (int i = 0; i < N; i++)
        {
            // Calculate the new index after rotation
            int newIndex = (i + K) % N;
            rotated[newIndex] = A[i];
        }

        return rotated;
    }
}
