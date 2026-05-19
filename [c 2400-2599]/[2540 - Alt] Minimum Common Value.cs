/*
Last Solved: 19.05.26
Topics Utilised: Two Pointer
Link: https://leetcode.com/problems/minimum-common-value/
Time Complexity: O(n + m) [where n = length of nums1 & m = length of nums 2]
Space Complexity: O(1)
*/

public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {

        int a = 0, b = 0;
        while (a < nums1.Length && b < nums2.Length)
        {
            if (nums1[a] == nums2[b])
                return nums1[a];

            // nums1 at a is the bigger int, increment b
            if (nums1[a] > nums2[b])
                b++;
            // else nums2 at b must be bigger, increment a
            else
                a++;
        }

        return -1;
    }
}
