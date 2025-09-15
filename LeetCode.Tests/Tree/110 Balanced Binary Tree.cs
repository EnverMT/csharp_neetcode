using Leetcode.Tree;
using Leetcode.Tree._110_Balanced_Binary_Tree;

namespace Leetcode.Tests.Tree;

public class _110_Balanced_Binary_Tree
{
    private readonly Solution _solution = new();

    [Fact]
    public void _110_Balanced_Binary_Tree_Test_1()
    {
        int?[] root = [1, 2, 3, null, null, 4];
        bool result = true;
        TreeNode? rootTreeNode = TreeBase.ConvertArrayToTree(root);
        bool output = _solution.IsBalanced(rootTreeNode!);
        Assert.Equal(output, result);
    }
}
