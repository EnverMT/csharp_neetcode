using Leetcode.Linked_List;

namespace Leetcode.Tree._110_Balanced_Binary_Tree;

public class Solution
{
    private bool _isBalanced = true;

    public bool IsBalanced(TreeNode? root)
    {
        if (root == null) return _isBalanced;

        GetHeight(root);

        return _isBalanced;
    }

    private int GetHeight(TreeNode? node)
    {
        if (node?.val == null) return 0;

        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);

        if (Math.Abs(leftHeight - rightHeight) > 1)
        {
            _isBalanced = false;
        }

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
