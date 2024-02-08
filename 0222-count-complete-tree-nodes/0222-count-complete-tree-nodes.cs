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
    public int CountNodes(TreeNode root) {
        int leftHeight = GetHeight(root, true);
        if(leftHeight == GetHeight(root, false))
            return (int)Math.Pow(2, leftHeight) - 1;

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }

    private int GetHeight(TreeNode node, bool isLeft){
        if(node == null)
            return 0;
        
        return isLeft ? GetHeight(node.left, true) + 1 : GetHeight(node.right, false) + 1;
    }
}