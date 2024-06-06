using Leetcode.Linked_List;
using Leetcode.Linked_List._138_Copy_List_with_Random_Pointer;

namespace Leetcode.Tests.Linked_List;

public class _138_Copy_List_with_Random_Pointer
{
    private readonly Solution _solution = new();

    [Fact]
    public void Test1()
    {
        int?[][] head = [[7, null], [13, 0], [11, 4], [10, 2], [1, 0]];
        int?[][] output = [[7, null], [13, 0], [11, 4], [10, 2], [1, 0]];

        Node node = Node.FromArray(head);
        Node resultNode = _solution.CopyRandomList(node);
        Node outputNode = Node.FromArray(output);

        for (Node? c1 = outputNode, c2 = resultNode; c1 != null; c1 = c1.next, c2 = c2.next)
        {
            Assert.Equal(c1.val, c2.val);
        }

        Assert.NotSame(node, resultNode);
    }

    [Fact]
    public void Test2()
    {
        int?[][] head = [[1, 1], [2, 1]];
        int?[][] output = [[1, 1], [2, 1]];

        Node node = Node.FromArray(head);
        Node resultNode = _solution.CopyRandomList(node);
        Node outputNode = Node.FromArray(output);

        for (Node? c1 = outputNode, c2 = resultNode; c1 != null; c1 = c1.next, c2 = c2.next)
        {
            Assert.Equal(c1.val, c2.val);
        }

        Assert.NotSame(node, resultNode);
    }

    [Fact]
    public void Test3()
    {
        int?[][] head = [[3, null], [3, 0], [3, null]];
        int?[][] output = [[3, null], [3, 0], [3, null]];

        Node node = Node.FromArray(head);
        Node resultNode = _solution.CopyRandomList(node);
        Node outputNode = Node.FromArray(output);

        for (Node? c1 = outputNode, c2 = resultNode; c1 != null; c1 = c1.next, c2 = c2.next)
        {
            Assert.Equal(c1.val, c2.val);
        }

        Assert.NotSame(node, resultNode);
    }
}
