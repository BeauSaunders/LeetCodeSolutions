/*
Last Solved: 30.10.24
Topics Utilised: Linked Lists
Link: https://leetcode.com/problems/reverse-linked-list/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) return head;

        ListNode curNode = head;
        ListNode prevNode = null;
        while (curNode != null){
            ListNode nxt = curNode.next;
            curNode.next = prevNode;
            prevNode = curNode;
            curNode = nxt;
        }

        return prevNode;
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
