/*
Last Solved: 11.02.25
Topics Utilised: Depth First Search
Link: https://leetcode.com/problems/binary-tree-preorder-traversal/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        if (root == null)
            return new List<int>();
        
        List<int> res = new List<int>(); // create a new list
        res.Add(root.val); // add root value to start of list

        // DFS down the left child
        if (root.left != null)
            res.AddRange(PreorderTraversal(root.left));
        
        // DFS down the right child
        if (root.right != null)
            res.AddRange(PreorderTraversal(root.right));

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
