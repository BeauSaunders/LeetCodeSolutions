/*
Last Solved: 20.05.25
Topics Utilised: Prefix Sum
Link: https://leetcode.com/problems/zero-array-transformation-i/
Time Complexity: O(q + n) [q = process every query, n = prefix sum, n = comparison]
Space Complexity: O(n) [diff = n + 1, dummy = n]
*/

public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        // edge cases
        if (nums == null || queries == null)
            return false;

        int[] diff = new int[nums.Length + 1];
        
        // foreach queary
        for (int i = 0; i < queries.Length; i++){  
            int l = queries[i][0], r = queries[i][1];

            diff[l]++;
            diff[r + 1]--;
        }

        // calculate prefix sum
        int[] dummy = new int[nums.Length];
        dummy[0] = diff[0];
        for (int j = 1; j < dummy.Length; j++){
            dummy[j] = dummy[j - 1] + diff[j];
        }

        // check if dummy vals >= nums vals
        for (int k = 0; k < nums.Length; k++){
            // if the dummy has a smaller value than nums
            if (dummy[k] < nums[k])
                return false;
        }

        return true;
    }
}
