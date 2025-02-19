/*
Last Solved: 19.02.25
Topics Utilised: Binary Search
Link: https://leetcode.com/problems/search-insert-position/
Time Complexity: O(log(n))
Space Complexity: O(1)
*/

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length - 1, mid = 0;

        while (l <= r)
        {
            mid = l + ((r - l) / 2);

            // target bigger than mid val
            if (target > nums[mid])
            {
                l = mid + 1;
            }
            // target smaller than mid val
            else if (target < nums[mid])
            {
                r = mid - 1;
            }
            // target found
            else
            {
                return mid;
            }
        }

        // the value was not found
        // return the last l value (that's where insert would have been)
        return l;
    }
}
