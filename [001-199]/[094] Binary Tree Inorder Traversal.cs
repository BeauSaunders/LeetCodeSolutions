/*
Last Solved: 20.01.25
Topics Utilised: DFS
Link: https://leetcode.com/problems/binary-tree-inorder-traversal/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    List<int> res = new List<int>();

    public IList<int> InorderTraversal(TreeNode root) {
        if (root == null)
            return new List<int>();

        // if node has left child
        if (root.left != null)
            InorderTraversal(root.left); // recursively go down left side

        // add the current nodes value to the list
        res.Add(root.val); // this val must be in middle to keep binary structure (i.e. all left vals first, root, all right vals)
        
        // if node has right child
        if (root.right != null)
            InorderTraversal(root.right); // recursively go down right side

        return res;
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
