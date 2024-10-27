/*
Last Solved: 27.10.24
Topics Utilised: Binary Search
Link: https://leetcode.com/problems/binary-search/
Time Complexity: O(log n)
Space Complexity: O(1)
*/

public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r){
            int mid = l + ((r - l) / 2);

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
                r = mid - 1;
            else
                l = mid + 1;
        }

        return -1;
    }
}
