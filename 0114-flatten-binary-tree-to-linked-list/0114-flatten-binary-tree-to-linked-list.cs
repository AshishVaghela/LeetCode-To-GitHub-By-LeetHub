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
    public void Flatten(TreeNode root) {
        FlattenTree(root);
    }

    private TreeNode FlattenTree(TreeNode root){
        if(root == null){
            return null;
        }
        
        TreeNode lastNode = root;
        if(root.left != null){
            lastNode = FlattenTree(root.left);
            
            lastNode.right = root.right;
            root.right = root.left;
            root.left = null;
        }

        return FlattenTree(root.right) ?? lastNode;
    }
}