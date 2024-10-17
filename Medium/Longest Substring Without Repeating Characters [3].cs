/*
Last Solved: 16.10.24
Topics Utilised: Dynamic Sliding Window, HashSet
Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        if (s.Length == 1) return 1;

        //Can't have duplicates in HashSet
        HashSet<char> chars = new HashSet<char>();

        int current = 0;
        int max = 0;
        int left = 0;
        //Increment right pointer every loop
        for (int right = 0; right < s.Length; right++){
            //While char at right pointer already exists in HashSet
            while (!chars.Add(s[right])){
                //Increment left point and remove the left pointer char from the HashSet
                chars.Remove(s[left]);
                left++;
            }
            //The right pointer char is now unique

            //Current length of dynamic sliding window
            current = right - left + 1;

            //Update max length so far if larger
            if (current > max) max = current;
        }

        return max;
    }
}
