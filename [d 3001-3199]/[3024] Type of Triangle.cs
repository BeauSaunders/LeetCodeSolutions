/*
Last Solved: 19.05.25
Topics Utilised: HashSet, Switch Statement
Link: https://leetcode.com/problems/type-of-triangle/
Time Complexity: O(1)
Space Complexity: O(1)
*/

public class Solution {
    public string TriangleType(int[] nums) {
        if (nums == null || nums.Length != 3)
            return "none";

        // sum of 2 sides much be > remaining side
        if (nums[0] + nums[1] <= nums[2] || 
            nums[0] + nums[2] <= nums[1] ||
            nums[1] + nums[2] <= nums[0])
        {
            return "none";   
        }

        HashSet<int> unique = new();
        unique.Add(nums[0]);

        unique.Add(nums[1]); // if not unique, doesn't get added
        unique.Add(nums[2]); // if not unique, doesn't get added

        if (unique.Count == 1)
            return "equilateral";

        switch (unique.Count)
        {
            case 2:
                return "isosceles";
            case 3:
                return "scalene";
            default:
                return "none";
        }
    }
}
