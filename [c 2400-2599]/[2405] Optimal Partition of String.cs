/*
Last Solved: 25.11.24
Topics Utilised: HashSet
Link: https://leetcode.com/problems/optimal-partition-of-string/description/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public int PartitionString(string s) {
        // edge cases
        if (String.IsNullOrEmpty(s))
            return 0;
        if (s.Length == 1)
            return 1;

        HashSet<char> chars = new HashSet<char>();

        // at least 1 substring (declare the first)
        int substrings = 1;
        for (int i = 0; i < s.Length; i++)
        {
            // this char already exists in hashset
            if (!chars.Add(s[i]))
            {
                // declare that a new substring is being formed
                substrings++;

                // clear the already tracked chars for this substring
                chars.Clear();

                // add the current char
                chars.Add(s[i]);
            }
        }

        return substrings;
    }
}
