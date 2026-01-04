"""
Topics Utilised: Hash Table
Time Complexity: O(n)
Space Complexity: O(n)
"""

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        
        numsDict = {}
        numsLen = len(nums)
        # for each num in nums
        for i in range(numsLen):
            remainder = target - nums[i]

            # if dict contains target - num
            if remainder in numsDict:
                # return curIndex, dict[num]
                return [i, numsDict[remainder]]
            # else remainder not in dict, add this num to the dict
            else:
                numsDict[nums[i]] = i
