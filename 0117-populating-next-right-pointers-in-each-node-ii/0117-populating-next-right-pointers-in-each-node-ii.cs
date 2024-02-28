/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root == null)
            return null;

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);

        Node temp;
        int count = 0;

        while(q.Count > 0){
            count = q.Count;

            while(count > 0){
                temp = q.Dequeue();
                count--;

                temp.next = count > 0 ? q.Peek() : null;

                if(temp.left != null)
                    q.Enqueue(temp.left);
                if(temp.right != null)
                    q.Enqueue(temp.right);
            }
        }

        return root;
    }
}