/*
Last Solved: 11.11.24
Topics Utilised: Trees, Depth First Search (DFS)
Link: https://leetcode.com/problems/invert-binary-tree/description/
Time Complexity: O(n)
Space Complexity: O(h) [where h is the height of the tree]
*/

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;

        //Store tmp node
        TreeNode newR = root.left;

        //Recursively invert leafs
        root.left = InvertTree(root.right);
        root.right = InvertTree(newR);

        return root;
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
