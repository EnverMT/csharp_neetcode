using Leetcode.Tree;
using Leetcode.Tree._104_Maximum_Depth_of_Binary_Tree;

namespace Leetcode.Tests.Tree;

public class _104_Maximum_Depth_of_Binary_Tree
{
    private Solution _solution = new();
    private Base _base = new();

    [Fact]
    public void _104_Maximum_Depth_of_Binary_Tree_Test_1()
    {
        int[] root = [1, 2, 3];
        int result = 3;

        TreeNode? rootTreeNode = _base.ConvertArrayToTree(root);
        int output = _solution.MaxDepth(rootTreeNode);

        Assert.Equal(output, result);
    }
}
