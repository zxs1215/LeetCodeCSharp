public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
        return 1 + max(MaxDepth(root.left), MaxDepth(root.right));
    }
    private int max(int x, int y)
    {
        if (y > x) return y;
        return x;
    }
}