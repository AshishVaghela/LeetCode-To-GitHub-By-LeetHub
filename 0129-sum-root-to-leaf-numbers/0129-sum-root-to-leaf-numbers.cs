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
    public int SumNumbers(TreeNode root) {
        int total = 0;
        string numberText = root.val.ToString();
        DFS(root, numberText, ref total);
        return total;
    }

    private void DFS(TreeNode node, string numberText, ref int total){
        if(node.left == null && node.right == null){
            total += Int32.Parse(numberText);
        }

        if(node.left != null){
            DFS(node.left, numberText + node.left.val, ref total);
        }

        if(node.right != null){
            DFS(node.right, numberText + node.right.val, ref total);
        }
    }
}