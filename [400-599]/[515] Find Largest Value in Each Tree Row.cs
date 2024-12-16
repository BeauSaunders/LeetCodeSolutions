/*
Last Solved: 16.12.24
Topics Utilised: BFS
Link: https://leetcode.com/problems/find-largest-value-in-each-tree-row/description/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public IList<int> LargestValues(TreeNode root) {
        // edge case
        if (root == null)
            return new List<int>();

        List<int> largest = new List<int>();
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);

        // while there are nodes remaining
        while (nodes.Count > 0){
            int maxVal = Int32.MinValue;

            // foreach node at this depth
            for (int i = 0, nodeCount = nodes.Count; i < nodeCount; i++){
                TreeNode node = nodes.Dequeue();

                // if this is the biggest at this depth so far, will update it
                maxVal = Math.Max(maxVal, node.val);

                // add child nodes to queue
                if (node.left != null)
                    nodes.Enqueue(node.left);
                if (node.right != null)
                    nodes.Enqueue(node.right);
            }

            // add the largest at this depth to the list
            largest.Add(maxVal);
        }

        return largest;
    }
}

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
