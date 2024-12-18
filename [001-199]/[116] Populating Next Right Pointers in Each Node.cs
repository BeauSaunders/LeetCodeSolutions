/*
Last Solved: 18.12.24
Topics Utilised: BFS
Link: https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public Node Connect(Node root) {
        // edge case
        if (root == null)
            return null;

        // add root to queue
        Queue<Node> nodeQ = new Queue<Node>();
        nodeQ.Enqueue(root);

        // while nodes remain in the queue
        while (nodeQ.Count > 0)
        {
            // for each node at this level
            for (int i = 0, nodeCount = nodeQ.Count; i < nodeCount; i++)
            {
                Node node = nodeQ.Dequeue();

                if (node.left == null || node.right == null)
                    continue;

                // set left pointer's next to right pointer
                node.left.next = node.right;

                // if there is another node to process in this queue, 
                if (i + 1 < nodeCount)
                {
                    Node nextNode = nodeQ.Peek();

                    // link this node's right to the next one's left
                    node.right.next = nextNode.left;
                }

                // add this node's children to the queue
                // must be done at the end so it follows FIFO correctly
                if (node.left != null)
                    nodeQ.Enqueue(node.left);
                if (node.right != null)
                    nodeQ.Enqueue(node.right);
            }
        }

        return root;
    }
}

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/
