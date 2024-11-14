/*
Last Solved: 14.11.24
Topics Utilised: Linked List
Link: https://leetcode.com/problems/merge-two-sorted-lists/
Time Complexity: O(n + m) [where n = number of nodes in list1 & m = number of nodes in list2]
Space Complexity: O(1) [as pointers are rearranged (no extra lists are created)]
*/

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        //Fake head
        ListNode dummy = new ListNode();

        //Pointer
        ListNode current = dummy;
        while (list1 != null && list2 != null){
            //l1 into list
            if (list1.val < list2.val){
                current.next = list1;
                list1 = list1.next;
            }
            //l2 into list
            else{
                current.next = list2;
                list2 = list2.next;
            }

            //Update pointer
            current = current.next;
        }

        //Left over l1 nodes
        while (list1 != null){
            current.next = list1;
            list1 = list1.next;
            current = current.next;
        }

        //Left over l2 nodes
        while (list2 != null){
            current.next = list2;
            list2 = list2.next;
            current = current.next;
        }

        //Real head (next of fake head)
        return dummy.next;
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
