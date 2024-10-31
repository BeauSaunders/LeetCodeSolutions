/*
Last Solved: 31.10.24
Topics Utilised: Two Pointers, Linked Lists
Link: https://leetcode.com/problems/linked-list-cycle/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null) return false;

        ListNode s = head;
        ListNode f = head;
        //f.next ensures the next node exists (as we need to reference it for next.next)
        while (f != null && f.next != null){
            s = s.next;
            f = f.next.next;

            if (f == s)
                return true; 
        }

        return false;
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
