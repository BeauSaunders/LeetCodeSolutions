/*
Last Solved: 12.11.24
Topics Utilised: Trees, Depth First Search (DFS)
Link: https://leetcode.com/problems/same-tree/
Time Complexity: O(p + q)
Space Complexity: O(h)
*/

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        //If one of the roots are null
        if (p == null || q == null){
            //True if they are both null, false if only 1 is null
            return p == q;
        }
        
        //If node vals are not equal, don't bother checking any further
        if (p.val != q.val){
            return false;
        }

        //Recursively check leaf nodes, return overall result
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
