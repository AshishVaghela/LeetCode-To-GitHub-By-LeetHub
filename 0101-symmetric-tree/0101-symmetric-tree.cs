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
    public bool IsSymmetric(TreeNode root) {
        return DFS(root.left, root.right);    
    }

    private bool DFS(TreeNode node1, TreeNode node2){
        if(node1 == node2){
            return true;
        }

        if(node1 == null || node2 == null || node1.val != node2.val){
            return false;
        }

        bool isSame = DFS(node1.left, node2.right);
        if(isSame){
            isSame = DFS(node1.right, node2.left);
        }
        return isSame;
    }
}