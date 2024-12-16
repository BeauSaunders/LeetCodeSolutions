/*
Last Solved: 16.12.24
Topics Utilised: DFS
Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
Time Complexity: O(n) 
Space Complexity: O(h) [where h is the height of the tree (on the stack due to recursion)]
*/

public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;

        // depth of self + max depth of children (recursive)
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
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
