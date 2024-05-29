namespace Leetcode.Tree._226_Invert_Binary_Tree;

public class Solution
{
    public TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null) return null;

        TreeNode? left = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(left);

        GC.Collect();

        return root;        
    }
}
