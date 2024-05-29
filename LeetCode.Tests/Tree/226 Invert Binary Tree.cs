using Leetcode.Tree;
using Leetcode.Tree._226_Invert_Binary_Tree;

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

        TreeNode? rootTreeNode = _base.ConvertArrayToTree(root);
        TreeNode? outputTreeNode = _solution.InvertTree(rootTreeNode);

        int[] outputArray = _base.ConvertTreeToArray(outputTreeNode);

        Assert.Equal(output, outputArray);
    }

    [Fact]
    public void _226_Invert_Binary_Tree_Test_2()
    {
        int[] root = [4, 2, 7, 1, 3, 6, 9];
        int[] output = [4, 7, 2, 9, 6, 3, 1];

        TreeNode? rootTreeNode = _base.ConvertArrayToTree(root);
        TreeNode? outputTreeNode = _solution.InvertTree(rootTreeNode);

        int[] outputArray = _base.ConvertTreeToArray(outputTreeNode);

        Assert.Equal(output, outputArray);
    }

    [Fact]
    public void _226_Invert_Binary_Tree_Test_3()
    {
        int[] root = [];
        int[] output = [];

        TreeNode? rootTreeNode = _base.ConvertArrayToTree(root);
        TreeNode? outputTreeNode = _solution.InvertTree(rootTreeNode);

        int[] outputArray = _base.ConvertTreeToArray(outputTreeNode);

        Assert.Equal(output, outputArray);
    }

    [Fact]
    public void _226_Invert_Binary_Tree_Test_4()
    {
        int[] root = [1, 2, 3, 4, 5, 6, 7];
        int[] output = [1, 3, 2, 7, 6, 5, 4];

        TreeNode? rootTreeNode = _base.ConvertArrayToTree(root);
        TreeNode? outputTreeNode = _solution.InvertTree(rootTreeNode);

        int[] outputArray = _base.ConvertTreeToArray(outputTreeNode);

        Assert.Equal(output, outputArray);
    }
}
