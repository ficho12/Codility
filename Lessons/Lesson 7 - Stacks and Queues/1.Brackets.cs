using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// Result 100% Correctness 100% Performance 100% Task Score 100% Time Complexity O(N)

class Solution
{
    public int solution(string S)
    {
        // Create a new empty stack to track brackets
        var bracketStack = new Stack<char>();

        // Iterate over each character in the string
        foreach (var c in S)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                // If the character is an opening bracket, push it onto the stack
                bracketStack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                // If the character is a closing bracket, check if the top of the stack matches
                // If it does, pop the top of the stack and continue iterating.
                // If it doesn't, return 0 (invalid).
                if (bracketStack.Count == 0) return 0;
                var top = bracketStack.Pop();
                if (c == ')' && top != '(') return 0;
                if (c == '}' && top != '{') return 0;
                if (c == ']' && top != '[') return 0;
            }
        }

        // If the stack is empty at the end of iteration, the string is valid
        // Otherwise, return 0 (invalid).
        return bracketStack.Count == 0 ? 1 : 0;
    }
}
