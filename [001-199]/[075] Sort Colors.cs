/*
Last Solved: 30.05.25
Topics Utilised: Bubble Sort
Link: https://leetcode.com/problems/sort-colors/
Time Complexity: O(n²)
Space Complexity: O(1)
*/

public class Solution {
    public void SortColors(int[] nums) {
        // edge cases
        if (nums == null || nums.Length <= 0)
            return;

        // bubble sort
        // foreach int in nums[]
        for (int i = 0; i < nums.Length - 1; i++)
        {
            // compare each pair
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                // if l > r
                if (nums[j] > nums[j + 1])
                {
                    int bigger = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = bigger;
                }
            }
        }
    }
}
