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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null){
            return true;
        }
        if(p == null){
            return false;
        }
        if(q == null){
            return false;
        }
        return DFS(p, q, true);
    }
    private bool DFS(TreeNode p, TreeNode q, bool isSame)
    {
        if(!isSame){
            return false;
        }

        if(p.val != q.val){
            return false;
        }

        if(p.left != null){
            if(q.left == null){
                return false;
            }
            else{
                isSame = DFS(p.left, q.left, true);
            }
        }
        else{
            if(q.left != null){
                return false;
            } 
        }

        if(!isSame){
            return false;
        }

        if(p.right != null){
            if(q.right == null){
                return false;
            }
            else{
                isSame = DFS(p.right, q.right, true);
            }
        }
        else{
            if(q.right != null){
                return false;
            } 
        }

        return isSame;
    }
}