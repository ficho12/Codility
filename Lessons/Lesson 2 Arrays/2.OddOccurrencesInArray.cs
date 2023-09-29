using System;
using System.Globalization;
using System.Linq;// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        int len = A.Length;
        int[] num = A;
        bool[] b = new bool[len];

        


        for (int i = 0; i < len; i++)
        {
            if (num.Contains(A[i]))
                bool[i] = true;
            else
                num[i] = A[i];
                bool[i] = false;
        }

        for (int i = 0; i < len; i++)
        {
            if (bool[i] == false)
                
                return num[i];
        }

        return num.Distinct().ToArray()[0];
    }
}
