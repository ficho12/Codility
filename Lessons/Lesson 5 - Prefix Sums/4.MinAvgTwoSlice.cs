using System;

// Result 100% Correctness 100% Performance 100% Task Score 100% Time Complexity O(N)

class Solution
{
    public int solution(int[] A)
    {
        int len = A.Length;
        int minAverageIndex = 0;
        double minAverage = double.MaxValue;

        // Calculate the prefix sum of the array.
        int[] prefixSum = new int[len + 1];
        for (int i = 0; i < len; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + A[i];
        }

        for (int P = 0; P < len - 1; P++)
        {
            // Consider slices of size 2 and 3 (if possible).
            for (int sliceSize = 2; sliceSize <= 3 && P + sliceSize - 1 < len; sliceSize++)
            {
                int Q = P + sliceSize - 1;

                // Calculate the sum of the slice (P to Q) using prefix sum.
                int sliceSum = prefixSum[Q + 1] - prefixSum[P];

                // Calculate the average of the slice.
                double avg = (double)sliceSum / sliceSize;

                if (avg < minAverage)
                {
                    minAverage = avg;
                    minAverageIndex = P;
                }
            }
        }

        return minAverageIndex;
    }
}
