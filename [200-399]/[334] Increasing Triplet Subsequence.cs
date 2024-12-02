/*
Last Solved: 02.12.24
Topics Utilised: Greedy, Two Pointers
Link: https://leetcode.com/problems/increasing-triplet-subsequence/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        // edge case
        if (nums.Length < 3)
            return false;

        // tracks the triplet values
        int smallest = int.MaxValue, secondSmallest = int.MaxValue;

        for (int i = 0; i < nums.Length; i++) 
        {
            // if smaller than the smallest num
            if (nums[i] <= smallest)
            {
                smallest = nums[i];
            }
            // if smaller than the 2nd smallest number 
            // (won't be smaller than 0th case since it's an else if statement)
            else if (nums[i] <= secondSmallest)
            {
                secondSmallest = nums[i];
            }
            // this number is larger than both
            else
            {
                return true;
            }
        }

        return false;
    }
}
