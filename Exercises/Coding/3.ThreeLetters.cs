using System;
using System.Text;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public string solution(int A, int B) {
        StringBuilder result = new StringBuilder();
        Console.WriteLine("DEBUG: ");
        char a = 'a';
        char b = 'b';
        char lastChar = 'X';
        char beforeLastChar = 'Z';
        
        while (A > 0 || B > 0) {

            if(A>B){
                // Check if we can add 'a' without three consecutive 'a's
                if (!((lastChar == beforeLastChar) && lastChar == a)) {
                    result.Append('a');
                    Console.WriteLine("1 a");
                    A--;
                    beforeLastChar = lastChar;
                    lastChar = 'a';
                }
                // Check if we can add 'b' without three consecutive 'b's
                else if (!((lastChar == beforeLastChar) && lastChar == b)) {
                    result.Append('b');
                    Console.WriteLine("1 b");
                    B--;
                    beforeLastChar = lastChar;
                    lastChar = 'b';
                }  
            }else{
                // Check if we can add 'b' without three consecutive 'b's
                if (!((lastChar == beforeLastChar) && lastChar == b)) {
                    result.Append('b');
                    Console.WriteLine("2 b");
                    B--;
                    beforeLastChar = lastChar;
                    lastChar = 'b';
                }  
                    // Check if we can add 'a' without three consecutive 'a's
                else if (!((lastChar == beforeLastChar) && lastChar == a)) {
                    result.Append('a');
                    Console.WriteLine("2 a");
                    A--;
                    beforeLastChar = lastChar;
                    lastChar = 'a';
                }
            }  
        }
        
        return result.ToString();
    }
}
