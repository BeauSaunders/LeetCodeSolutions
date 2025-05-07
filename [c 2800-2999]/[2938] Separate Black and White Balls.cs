/*
Last Solved: 07.05.25
Topics Utilised: Greedy Algorithm, Strings
Link: https://leetcode.com/problems/separate-black-and-white-balls/description/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public long MinimumSteps(string s) {
        // edge cases
        if (s == null || s.Length <= 0)
            return 0;

        long steps = 0;
        int blackCount = 0;

        for (int i = 0; i < s.Length; i++){
            if (s[i] == '1') // this is a black ball
                blackCount++;
            else // this is a white ball
                steps += blackCount; // how many steps this white ball needs to take to pass all black balls
        }

        return steps;
    }
}
