using Leetcode.Tree;
using Leetcode.Tree._543_Diameter_of_Binary_Tree;

namespace Leetcode.Tests.Tree;

public class _543_Diameter_of_Binary_Tree
{
    private readonly Solution _solution = new();

    [Fact]
    public void Test_1()
    {
        int?[] root = [1, 2, 3, 4, 5];
        int result = 3;

        TreeNode? rootTreeNode = TreeBase.ConvertArrayToTree(root);
        int output = _solution.DiameterOfBinaryTree(rootTreeNode);

        Assert.Equal(result, output);
    }

    [Fact]
    public void Test_2()
    {
        int?[] root = [1, 2];
        int result = 1;

        TreeNode? rootTreeNode = TreeBase.ConvertArrayToTree(root);
        int output = _solution.DiameterOfBinaryTree(rootTreeNode);

        Assert.Equal(result, output);
    }

    [Fact]
    public void Test_3()
    {
        int?[] root = [1, null, 2, 3, 4, 5];
        int result = 3;

        TreeNode? rootTreeNode = TreeBase.ConvertArrayToTree(root);
        int output = _solution.DiameterOfBinaryTree(rootTreeNode);

        Assert.Equal(result, output);
    }

    [Fact]
    public void Test_4()
    {
        int?[] root = [1, 2, 3];
        int result = 2;

        TreeNode? rootTreeNode = TreeBase.ConvertArrayToTree(root);
        int output = _solution.DiameterOfBinaryTree(rootTreeNode);

        Assert.Equal(result, output);
    }
}