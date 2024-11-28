/*
Last Solved: 30.09.24
Topics Utilised: Hash Table, Stack
Link: https://leetcode.com/problems/valid-parentheses/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> pDict = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        Stack<char> pStack = new Stack<char>();

        foreach (char c in s)
        {
            //Opening bracket
            if (c is '(' or '{' or '['){
                pStack.Push(c);
            }
            //Closing bracket
            else{
                //No remaining brackets left in the stack (invalid)
                if (pStack.Count == 0)
                    return false;

                //If the character before is not the related bracket
                if (pDict[pStack.Pop()] != c)
                    return false;
            }
        }

        //Some element(s) still remain, therefore it is false (e.g. input = '[')
        if (pStack.Count > 0)
            return false;

        return true;
    }
}
