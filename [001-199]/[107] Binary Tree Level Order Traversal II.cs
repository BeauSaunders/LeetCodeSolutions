/*
Last Solved: 17.12.24
Topics Utilised: BFS, Stack
Link: https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
Time Complexity: O(n)
Space Compelxity: O(n)
*/

public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        // edge case
        if (root == null)
            return new List<IList<int>>();

        Stack<List<int>> stack = new Stack<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // get list of all ints and push them to stack
        while (queue.Count > 0)
        {
            int nodeCount = queue.Count;
            // holds vals at this lvl
            List<int> vals = new List<int>();
            
            // foreach node at this lvl
            for (int i = 0; i < nodeCount; i++)
            {
                TreeNode node = queue.Dequeue();

                //  add val to list
                vals.Add(node.val);

                //  add child nodes to queue
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            // Push list to stack
            stack.Push(vals);
        }

        List<IList<int>> res = new List<IList<int>>();
        while (stack.Count > 0)
        {
            res.Add(stack.Pop());
        }

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
