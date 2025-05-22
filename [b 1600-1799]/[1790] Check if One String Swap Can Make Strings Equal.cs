/*
Last Solved: 22.05.25
Topics Utilised: strings, Lists
Link: https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if (s1 == null || s2 == null || s1.Length != s2.Length)
            return false;

        List<int> diffs = new List<int>();
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                if (diffs.Count < 2)
                {
                    diffs.Add(i);
                }
                // more than 2 differences, impossible
                else
                {
                    return false;
                }
            }
        }

        if (diffs.Count == 2)
        {
            int ind1 = diffs[0];
            int ind2 = diffs[1];

            if (s1[ind1] == s2[ind2] && s1[ind2] == s2[ind1])
                return true;
            else
                return false;
        }
        else
        {
            // if it's 1, return false
            return diffs.Count == 0;
        }
    }
}
