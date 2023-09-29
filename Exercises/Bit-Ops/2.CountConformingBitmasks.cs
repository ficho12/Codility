using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
 public int solution(int A, int B, int C)
{
    // Count the number of 1 bits set in A, B, and C
    int countA = CountSetBits(A);
    int countB = CountSetBits(B);
    int countC = CountSetBits(C);

    // Calculate the maximum possible value for 30-bit integers (2^30 - 1)
    int max30BitInt = (1 << 30) - 1;

    // Find the maximum integer that conforms to all masks using binary search
    int left = 0;
    int right = max30BitInt;
    int maxConformingInt = -1;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        // Check if mid conforms to all masks by comparing the set bits
        if ((mid & A) >= countA && (mid & B) >= countB && (mid & C) >= countC)
        {
            maxConformingInt = mid;
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    // Count the number of integers that conform to all masks
    int totalCount = maxConformingInt + 1;

    // Count the number of integers that do not conform to any mask
    totalCount -= CountNonConformingIntegers(A | B | C, maxConformingInt, countA + countB + countC);
    
    // Count the number of integers that conform to at least one mask
    totalCount -= CountNonConformingIntegers(A, maxConformingInt, countA);
    totalCount -= CountNonConformingIntegers(B, maxConformingInt, countB);
    totalCount -= CountNonConformingIntegers(C, maxConformingInt, countC);

    return totalCount;
}

private int CountSetBits(int n)
{
    int count = 0;
    while (n > 0)
    {
        count += n & 1;
        n >>= 1;
    }
    return count;
}

private int CountNonConformingIntegers(int mask, int maxConformingInt, int countSetBits)
{
    int left = 0;
    int right = maxConformingInt;
    int count = 0;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        // Check if mid conforms to the mask by comparing the set bits
        if ((mid & mask) >= countSetBits)
        {
            count += maxConformingInt - mid + 1;
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return count;
}
}
