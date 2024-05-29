using Leetcode.Tree._226_Invert_Binary_Tree;
using Leetcode.Tree;

namespace Leetcode.Tests.Tree;


public class _226_Invert_Binary_Tree
{
    private Solution _solution = new();
    private Base _base = new();

    [Fact]
    public void _226_Invert_Binary_Tree_Test_1()
    {
        int[] root = [1, 2, 3];
        int[] output = [1, 3, 2];

        TreeNode? rootTreeNode = _base.ConvertArrayToTree([1, 2, 3]);
        Assert.NotNull(rootTreeNode);

        TreeNode outputTreeNode = _solution.InvertTree(rootTreeNode);
        Assert.NotNull(outputTreeNode);

        int[] outputArray = _base.ConvertTreeToArray(outputTreeNode);

        Assert.Equal(output, outputArray);
    }
}
