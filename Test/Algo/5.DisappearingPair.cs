using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public string solution(string S) {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in S) {
            if (stack.Count > 0 && c == stack.Peek())
                stack.Pop();
            else
                stack.Push(c);
        }
        
        char[] resultArray = stack.ToArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}
