using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result 100% Correctness 100% Performance 0% Task Score 62% Time Complexity O(N * M)

class Solution
{
    public int[] solution(string S, int[] P, int[] Q)
    {
        int len = P.Length;
        int[] lowestImpact = new int[len];
        Array.Fill(lowestImpact, 4);
        int currentImpact = 0;
        for (int i = 0; i < len; i++)
        {
            //Console.WriteLine("Sequence from " + P[i] + " to " + Q[i]);
            for (int j = P[i]; j <= Q[i]; j++)
            {
                switch (S[j])
                {
                    case 'A':
                        currentImpact = 1;
                        break;
                    case 'C':
                        currentImpact = 2;
                        break;
                    case 'G':
                        currentImpact = 3;
                        break;
                    case 'T':
                        currentImpact = 4;
                        break;
                }
                //Console.Write(S[j]);
                if (currentImpact < lowestImpact[i])
                {
                    lowestImpact[i] = currentImpact;

                    if (currentImpact.Equals(1))
                        break;
                }
            }
        }

        return lowestImpact;
    }
}


/*

static string SortString(string input)
{
    char[] characters = input.ToArray();
    Array.Sort(characters);
    return new string(characters);
}

*/

/*
class Solution
{
    public int[] solution(string S, int[] P, int[] Q)
    {
        int[] lowestImpact = new int[P.Length];
        for (int i = 0; i < P.Length; i++)
        {
            Array.Sort(S.Substring(P[i], Q[i] - P[i]).ToArray()
          switch ()
            {
                case 'A':
                    lowestImpact[i] = 1;
                    break;
                case 'C':
                    lowestImpact[i] = 2;
                    break;
                case 'G':
                    lowestImpact[i] = 3;
                    break;
                case 'T':
                    lowestImpact[i] = 4;
                    break;
            }
        }
        return lowestImpact;
    }
}

 */
