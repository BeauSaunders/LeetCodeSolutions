"""
Last Solved: 05.01.26
Topics Utilised: Linked List
Link: https://leetcode.com/problems/merge-two-sorted-lists/
Time Complexity: O(n + m) [where n = number of nodes in list1 & m = number of nodes in list2]
Space Complexity: O(1) [as pointers are rearranged (no extra lists are created)]
"""

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        dummyHead = ListNode()
        curRes = dummyHead
        curOne = list1
        curTwo = list2

        # while there is a value that hasn't been added to the result
        while curOne or curTwo:
            # if no vals left in list 1
            if curOne is None:
                curRes.next = curTwo # add list 2 val
                curTwo = curTwo.next # move the list 2 pointer along
            # if no vals left in list 2
            elif curTwo is None:
                curRes.next = curOne # add list 1 val
                curOne = curOne.next # move the list 1 pointer along
            # there is a value in both (need comparison)
            else:
                # if val1 <= val2
                if curOne.val <= curTwo.val:
                    curRes.next = curOne # set the current node's val to list1's val
                    curOne = curOne.next # move the list 1 pointer along
                # else val2 < val1
                else:
                    curRes.next = curTwo # set the current node's val to list2's val
                    curTwo = curTwo.next # move the list 2 pointer along

            curRes = curRes.next # move current Pointer along

        return dummyHead.next
