/*
Last Solved: 30.10.24
Topics Utilised: Depth First Search, Binary Tree
Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public int MaxDepth(TreeNode root) {
        //If the node is null, don't include depth
        if (root == null) return 0;

        //Root node has a depth of 1
        int depth = 1;

        //Add to this depth, the maximum value from traversing the child nodes
        depth += Math.Max(MaxDepth(root.left), MaxDepth(root.right));

        return depth;
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
