/*
Last Solved: 14.05.25
Topics Utilised: Two Pointers
Link: https://leetcode.com/problems/container-with-most-water/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int MaxArea(int[] height) {
        if (height == null || height.Length <= 1)
            return 0;

        int max = 0;
        int l = 0, r = height.Length - 1;
        while (l < r)
        {
            // using the shortest line, multiply it by the gap difference
            int vol = Math.Min(height[l], height[r]) * (r - l);

            // update the max if it is the biggest so far
            max = Math.Max(vol, max);

            // if the l line is smaller than the r line, push it up
            if (height[l] < height[r])
                l++;
            // else r is smaller, pull is down
            else
                r--;
        }

        return max;
    }
}
