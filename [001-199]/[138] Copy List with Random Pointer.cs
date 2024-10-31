/*
Last Solved: 31.10.24
Topics Utilised: Linked List, Hash Table
Link: https://leetcode.com/problems/copy-list-with-random-pointer/
Time Complexity: O(n)
Space Compelxity: O(n)
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) return null;

        Dictionary<Node, Node> oldToNew = new();

        Node cur = head;
        while (cur != null){
            oldToNew[cur] = new Node(cur.val);
            cur = cur.next;
        }

        cur = head;
        while (cur != null){
            var newNode = oldToNew[cur];

            if (cur.next != null){
                newNode.next = oldToNew[cur.next];
            }

            if (cur.random != null){
                newNode.random = oldToNew[cur.random];
            }

            cur = cur.next;
        }

        return oldToNew[head];
    }
}

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/
