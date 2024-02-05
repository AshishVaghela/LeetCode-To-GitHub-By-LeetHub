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
public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        return DFS(root, targetSum);
    }

    private bool DFS(TreeNode node, int targetSum){
        if(node == null)
            return false;

        if(node.left == null && node.right == null){
            return node.val == targetSum;
        }

        return DFS(node.left, targetSum - node.val) || DFS(node.right, targetSum - node.val);
        
    }
}