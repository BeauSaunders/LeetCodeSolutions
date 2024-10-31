/*
Last Solved: 31.10.24
Topics Utilised: Hash Set, Linked Lists
Link: https://leetcode.com/problems/linked-list-cycle/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null) return false;

        HashSet<ListNode> seen = new HashSet<ListNode>();
        ListNode cur = head;
        while (cur != null){
            ListNode nxt = cur.next;

            //Already seen (cant't add)
            if (!seen.Add(nxt)){
                return true;
            }
            //Not yet seen, add
            else{
                cur = cur.next;
            }
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
