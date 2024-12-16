/*
Last Solved: 16.12.24
Topics Utilised: BFS
Link: https://leetcode.com/problems/binary-tree-level-order-traversal/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        // edge case
        if (root == null)
            return new List<IList<int>>();

        List<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int lvl = 0;
        while (queue.Count > 0)
        {
            List<int> lvlVals = new List<int>();

            // for each node at this lvl (since FIFO, will stop before new children)
            for (int i = 0, nodesAtLvl = queue.Count; i < nodesAtLvl; i++)
            {
                // dequeue the next node
                TreeNode node = queue.Dequeue();

                // store the node's val in the result at the current height
                lvlVals.Add(node.val);

                // add the child nodes
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)    
                    queue.Enqueue(node.right);
            }

            // add this layer's list of vals to the overall list
            res.Add(lvlVals);

            // go down the next layer
            lvl++;
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
