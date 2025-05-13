/*
Last Solved: 13.05.25
Topics Utilised: Binary Search
Link: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] res = new int[]{-1, -1};

        if (nums == null || nums.Length == 0)
            return res;

        int mid;
        int l = 0;
        int r = nums.Length - 1;
        while (l <= r)
        {
            mid = l + ((r - l) / 2);
            
            // if this number is the target
            if (nums[mid] == target)
            {
                int min = mid, max = mid;

                // push min pointer to min (sliding window)
                while (min >= 0 && nums[min] == target) min--;
                // push max pointer to max (sliding window)
                while (max < nums.Length && nums[max] == target) max++;
                
                // adjust for over/undershoot
                res[0] = min + 1;
                res[1] = max - 1;

                break;
            }
            // not big enough
            else if (target > nums[mid])
            {
                l = mid + 1;
            }
            // too big
            else
            {
                r = mid - 1;
            }
        }

        return res;
    }
}
