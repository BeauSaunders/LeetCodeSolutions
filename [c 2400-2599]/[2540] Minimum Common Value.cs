/*
Last Solved: 19.05.26
Topics Utilised: HashSet
Link: https://leetcode.com/problems/minimum-common-value/
Time Complexity: O(n + m) [where n = length of nums1 & m = length of nums 2]
Space Complexity: O(n) [where n = length of nums1]
*/

public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        HashSet<int> n1 = new(nums1);

        for (int i = 0; i < nums2.Length; i++)
        {
            if (n1.Contains(nums2[i]))
                return nums2[i];
        }

        return -1;
    }
}
