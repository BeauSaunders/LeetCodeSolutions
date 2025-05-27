/*
Last Solved: 27.05.25
Topics Utilised: Prefix Sum
Link: https://leetcode.com/problems/range-sum-query-immutable/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class NumArray {

    int[] pNums;

    public NumArray(int[] nums) {
        // init prefix array with extra index for 0
        pNums = new int[nums.Length + 1];
        pNums[0] = 0;

        // populate prefix sum array
        for (int i = 0; i < nums.Length; i++){
            pNums[i+1] = pNums[i] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        // r + 1 to account for extra index in prefix arr
        return pNums[right + 1] - pNums[left];
    }
}
