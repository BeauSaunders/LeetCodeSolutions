/*
Last Solved: 21.05.26
Topics Utilised: Strings
Link: https://leetcode.com/problems/remove-trailing-zeros-from-a-string/
Time Complexity: O(n) [where n = the length of the input string]
Space Complexity: O(1)
*/

public class Solution {
    public string RemoveTrailingZeros(string num) {
        int i = num.Length - 1;

        // while at the 0th or more index && the current character is a '0'
        while (i >= 0 && num[i] == '0')
        {
            i--;
        }

        // truncate the string
        return num.Substring(0, i + 1);
    }
}
