/*
Last Solved: 02.11.24
Topics Utilised: String Builder, Two Pointers
Link: https://leetcode.com/problems/reverse-words-in-a-string/
Time Complexity: O(n)
Space Compelxity: O(n)
*/

public class Solution {
    public string ReverseWords(string s) {
        StringBuilder sb = new StringBuilder();

        int l = 0;
        for (int r = 0; r < s.Length; r++){
            //Move l until it finds a letter
            while (l < s.Length && s[l] == ' '){
                l++;
            }

            //Start r from l pos
            r = l;
            //Move r until it finds a space
            while (r < s.Length && Char.IsLetterOrDigit(s[r])){
                r++;
            }

            if (l < r){
                //Not the first word
                if (sb.Length > 0){
                    sb.Insert(0, ' ');
                }

                sb.Insert(0, s.Substring(l, r - l));
            }

            //Move l to r to not re-use words
            l = r;
        }

        return sb.ToString();
    }
}
