"""
Topics Utilised: Hash Table
Time Complexity: O(n)
Space Complexity: O(n)
"""

class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """

        # track seen ints
        tracker = {}
        
        # for each int in nums
        for i in range(len(nums)):
            # number needed to find
            need = target - nums[i]

            # if it is in tracker
            if need in tracker:
                return [tracker[need], i]
            # else, track this number and index
            else:
                tracker[nums[i]] = i
