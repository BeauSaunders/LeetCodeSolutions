/*
Last Solved: 30.10.24
Topics Utilised: Dynamic Sliding Window, HashSet
Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
Time Complexity: O(n)
Space Compelxity: O(n)
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 0) return 0;

        int l = 0;
        int curLongest = 1;
        HashSet<char> curChars = new HashSet<char>();
        curChars.Add(s[l]);

        for (int r = 1; r < s.Length; r++){
            //While this char already exists, store the length, remove l char
            while (!curChars.Add(s[r])){
                curChars.Remove(s[l]);
                l++;
            }

            curLongest = Math.Max(curLongest, r - l + 1);
        }

        return curLongest;
    }
}
