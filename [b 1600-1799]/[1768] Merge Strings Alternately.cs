/*
Last Solved: 29.11.24
Topics Utilised: String Builder, Loops
Link: https://leetcode.com/problems/merge-strings-alternately/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sb = new StringBuilder();
        int w2Len = word2.Length;
        int i = 0;

        // for each letter in word1
        for (; i < word1.Length; i++)
        {
            sb.Append(word1[i]);

            // if word2 has a letter at i
            if (i < w2Len)
            {
                sb.Append(word2[i]);
            }
        }

        // while there are letters remaining in word2
        if (i < w2Len)
        {
            // add the remaining word
            sb.Append(word2.Substring(i, w2Len - i));
        }

        return sb.ToString();
    }
}
