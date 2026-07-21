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
    private List<int> result = new();
    public List<int> InorderTraversal(TreeNode root) {
        
        Helper(root);
        return result;
        
    }
    private void Helper(TreeNode root) {
        if(root == null && root == null)
            return;
        Helper(root.left);
        result.Add(root.val);
        Helper(root.right);
    }
}