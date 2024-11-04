/*
Last Solved: 04.11.24
Topics Utilised: Stack
Link: https://leetcode.com/problems/removing-stars-from-a-string/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++){
            //Remove last seen char
            if (s[i] == '*'){
                stack.Pop();
            }
            //Add char to stack
            else{
                stack.Push(s[i]);
            }
        }

        char[] arr = stack.ToArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
