/*
Last Solved: 07.12.24
Topics Utilised: Sliding Window, 
Link: https://leetcode.com/problems/minimum-size-subarray-sum/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        if (nums.Length < 1)
            return 0;

        // can never be larger than the length of the array
        int smallest = nums.Length + 1;
        int l = 0, r = 0, curTot = 0;
        while (l <= r && r < nums.Length)
        {
            curTot += nums[r];

            // while the current total is >= the target
            while (curTot >= target)
            {
                // if the current subsarray is smaller than the smallest, update smallest
                smallest = Math.Min(smallest, r - l + 1);

                // deduct the current left pointer value from the current total
                curTot -= nums[l];
                // increment the left pointer to see if it can be smaller and still valid
                l++;
            }
            // the current total isn't big enough
            r++;
        }

        // no valid subarray was found
        if (smallest == nums.Length + 1)
            return 0;
        else
            return smallest;
    }
}
