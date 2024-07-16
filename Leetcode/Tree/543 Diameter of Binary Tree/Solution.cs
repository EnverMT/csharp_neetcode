namespace Leetcode.Tree._543_Diameter_of_Binary_Tree;


public class Solution
{
    private int _result = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        Depth(root);

        return _result;
    }

    private int Depth(TreeNode? node)
    {
        if (node?.val == null)
            return -1;

        int left = Depth(node.left);
        int right = Depth(node.right);

        _result = Math.Max(_result, 2 + left + right);

        return 1 + Math.Max(left, right);
    }
}

