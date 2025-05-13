/*
Last Solved: 13.05.25
Topics Utilised: Binary Search
Link: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
Time Complexity: O(log n)
Space Complexity: O(1)
*/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        return new int[] {FindMin(nums, target), FindMax(nums, target)};
    }

    int FindMin(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;
        int mid, min = -1;
        while (l <= r)
        {
            mid = l + ((r - l) / 2);

            if (nums[mid] == target)
            {
                min = mid; // found the target
                r = mid - 1; // pull right pointer in
            }
            // too small
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

        return min;
    }

    int FindMax(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;
        int mid, max = -1;
        while (l <= r)
        {
            mid = l + ((r - l) / 2);

            if (nums[mid] == target)
            {
                max = mid; // found the target
                l = mid + 1; // pull left pointer in
            }
            // too small
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

        return max;
    }
}
