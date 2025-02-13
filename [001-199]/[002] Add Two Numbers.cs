/*
Last Solved: 13.02.25
Topics Utilised: Linked List, Math
Link: https://leetcode.com/problems/add-two-numbers/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode resRoot = new ListNode();
        ListNode curNode = resRoot;
        int carry = 0;

        // while at least one of the nodes are not null
        while (l1 != null || l2 != null){
            // if this node is null, default to 0
            int l1Val = 0;
            if (l1 != null)
                l1Val = l1.val;

            // if this node is null, default to 0
            int l2Val = 0;
            if (l2 != null)
                l2Val = l2.val;

            // add the node values and the carry
            int sum = l1Val + l2Val + carry;
            carry = 0; // reset the carry

            // if the sum is 2 digits
            if (sum > 9){
                carry = 1; // carry the 10 (as 1)
                sum = sum % 10; // set the sum to the right-most digit
            }
                
            curNode.next = new ListNode(sum); // set the sum to the node

            // update pointers for next iteration
            curNode = curNode.next;
            l1 = (l1.next != null) ? l1.next : null; // if the next pointer isn't null, assign it, else set it to null
            l2 = (l2.next != null) ? l2.next : null;
        }

        // if any carry remains (e.g. null nodes but carry 1)
        if (carry != 0)
            curNode.next = new ListNode(carry); // create the last node with the carry val

        return resRoot.next;
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
