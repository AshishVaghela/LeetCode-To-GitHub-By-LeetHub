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
public class BSTIterator {

    private TreeNode root = new TreeNode();
    private Stack<TreeNode> list = new Stack<TreeNode>();

    public BSTIterator(TreeNode root) {
        this.root = root;
        AddNext(root);
    }

    private void AddNext(TreeNode node){
        if(node == null)
            return;

        var temp = node;
        list.Push(temp);
        while(temp.left != null){
            temp = temp.left;
            list.Push(temp);
        }
    }
    
    public int Next() {
        var next = list.Pop();
        AddNext(next.right);
        return next.val;
    }
    
    public bool HasNext() {
        return list.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */