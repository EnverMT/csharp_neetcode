namespace Leetcode.Tree._104_Maximum_Depth_of_Binary_Tree;

public class Solution
{
    public int MaxDepth(TreeNode? root)
    {
        if (root == null)
            return 0;

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
