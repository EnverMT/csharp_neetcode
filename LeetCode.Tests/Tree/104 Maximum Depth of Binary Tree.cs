using Leetcode.Tree;
using Leetcode.Tree._104_Maximum_Depth_of_Binary_Tree;

namespace Leetcode.Tests.Tree;

public class _104_Maximum_Depth_of_Binary_Tree
{
    private readonly Solution _solution = new();

    [Fact]
    public void _104_Maximum_Depth_of_Binary_Tree_Test_1()
    {
        int?[] root = [1, 2, 3];
        int result = 2;

        TreeNode? rootTreeNode = Base.ConvertArrayToTree(root);
        int output = _solution.MaxDepth(rootTreeNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _104_Maximum_Depth_of_Binary_Tree_Test_2()
    {
        int?[] root = [1, null, 3];
        int result = 2;

        TreeNode? rootTreeNode = Base.ConvertArrayToTree(root);
        int output = _solution.MaxDepth(rootTreeNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _104_Maximum_Depth_of_Binary_Tree_Test_3()
    {
        int?[] root = [3, 9, 20, null, null, 15, 7];
        int result = 3;

        TreeNode? rootTreeNode = Base.ConvertArrayToTree(root);
        int output = _solution.MaxDepth(rootTreeNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _104_Maximum_Depth_of_Binary_Tree_Test_4()
    {
        int?[] root = [1, 2, 3, null, null, 4];
        int result = 3;

        TreeNode? rootTreeNode = Base.ConvertArrayToTree(root);
        int output = _solution.MaxDepth(rootTreeNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _104_Maximum_Depth_of_Binary_Tree_Test_5()
    {
        int?[] root = [];
        int result = 0;

        TreeNode? rootTreeNode = Base.ConvertArrayToTree(root);
        int output = _solution.MaxDepth(rootTreeNode);

        Assert.Equal(output, result);
    }
}
