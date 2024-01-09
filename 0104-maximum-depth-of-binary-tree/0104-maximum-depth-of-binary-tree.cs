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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        return DFS(root);
    }

    private int DFS(TreeNode node){
        int rightDepth = 1;
        int leftDepth = 1;
        
        if(node.left != null)
            leftDepth += DFS(node.left);
        
        if(node.right != null)
            rightDepth += DFS(node.right);
        
        if(leftDepth > rightDepth){
            return leftDepth;
        }
        return rightDepth;
    }
}