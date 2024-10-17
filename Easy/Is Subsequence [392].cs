/*
Last Solved: 12.10.24
Topics Utilised: Two Pointers
Link: https://leetcode.com/problems/is-subsequence/
*/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        //Edge case (empty s = subsequence always true)
        if (string.IsNullOrEmpty(s)) return true;
        //Edge case (empty t = no subsequence ever)
        if (string.IsNullOrEmpty(t)) return false;

        int searchInd = 0;
        int searchMax = s.Length - 1;

        //Foreach char in T (right pointer of T)
        for (int i = 0; i < t.Length; i++){
            //If the T char matches the S char
            if (t[i] == s[searchInd]){
                //All S chars checked and valid
                if (searchInd == searchMax){
                    return true;
                }

                //Increment search ind (left pointer of S)
                searchInd++;
            }
        }

        return false;
    }
}
