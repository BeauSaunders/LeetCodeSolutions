/*
Last Solved: 06.12.24
Topics Utilised: HashSet, Greedy
Link: https://leetcode.com/problems/maximum-number-of-integers-to-choose-from-a-range-i/
Time Complexity: O(k + n) [where k = number of banned ints (for hashset init) and where n = ints between 1 and n]
Space Complexity: O(k) [where k = number of banned ints]
*/

public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        // store banned ints in a hashset for quick lookup
        HashSet<int> bannedInts = new HashSet<int>(banned);

        int curSum = 0;
        int count = 0;
        // count up from 1 to n
        for (int i = 1; i <= n; i++)
        {
            // if not in the banned hashset &&
            // if the addition won't exceed maxSum
            if (!bannedInts.Contains(i) && curSum + i <= maxSum)
            {
                curSum += i;
                count++;

                // max sum was achieved, no need to continue trying
                if (curSum == maxSum)
                    break;

                // next sum could be smaller so continue
            }
        }

        return count;
    }
}
