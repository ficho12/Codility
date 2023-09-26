using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(Tree T) {
        if (T == null) {
            return 0;
        }
        
        int maxTurns = 0;
        FindLongestZigzag(T, 0, ref maxTurns);
        
        return maxTurns -1;
    }

    private void FindLongestZigzag(Tree node, int turnsSoFar, ref int maxTurns) {
        if (node == null) {
            return;
        }

        maxTurns = Math.Max(maxTurns, turnsSoFar);

        if (node.l != null) {
            if (node.r != null) {
                // If there's a left and right child, we can make a turn in either direction
                FindLongestZigzag(node.l, 1, ref maxTurns);
                FindLongestZigzag(node.r, 1, ref maxTurns);
            } else {
                // If there's only a left child, we can make a left turn
                FindLongestZigzag(node.l, turnsSoFar + 1, ref maxTurns);
            }
        } else if (node.r != null) {
            // If there's only a right child, we can make a right turn
            FindLongestZigzag(node.r, turnsSoFar + 1, ref maxTurns);
        }
    }
}