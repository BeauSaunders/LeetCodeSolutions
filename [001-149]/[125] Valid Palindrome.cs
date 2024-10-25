/*
Last Solved: 25.10.24
Topics Utilised: Two Pointers
Link: https://leetcode.com/problems/two-sum/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public bool IsPalindrome(string s) {
        //Edge cases (1 character must be the same as itself)
        if (s.Length == 1) return true;
        //No characters are not palindromic
        else if (s.Length == 0) return false;

        //Ensure capitalisation is ignored
        s = s.ToLower();

        int l = 0;
        int r = s.Length - 1;

        while (l < r){
            //Increment pointer until it finds a valid character
            while (!Char.IsLetterOrDigit(s[l]) && l < r){
                l++;
            }
            while (!Char.IsLetterOrDigit(s[r]) && r > l){
                r--;
            }

            //If left pointer char doesn't match right pointer char
            if (s[l] != s[r]) 
                return false;

            l++;
            r--;
        }

        return true;
    }
}
