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
    private List<int> res = new();
    public List<int> PostorderTraversal(TreeNode root) {
        PostOrder(root);
        return res;
    }
    private void PostOrder(TreeNode root) {
        if (root == null) return;
        PostOrder(root.left);
        PostOrder(root.right);
        res.Add(root.val);
    }
}