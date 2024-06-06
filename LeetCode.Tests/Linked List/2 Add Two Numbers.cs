using Leetcode.Linked_List;
using Leetcode.Linked_List._2_Add_Two_Numbers;

namespace Leetcode.Tests.Linked_List;

public class _2_Add_Two_Numbers
{
    private readonly Solution _solution = new();

    [Fact]
    public void Test_1()
    {
        int[] l1 = [2, 4, 3];
        int[] l2 = [5, 6, 4];
        int[] output = [7, 0, 8];

        ListNode node1 = ListNode.FromArray(l1);
        ListNode node2 = ListNode.FromArray(l2);

        ListNode result = _solution.AddTwoNumbers(node1, node2);
        int[] resultArr = ListNode.ToArray(result);

        Assert.Equal(output, resultArr);
    }

    [Fact]
    public void Test_2()
    {
        int[] l1 = [0];
        int[] l2 = [0];
        int[] output = [0];

        ListNode node1 = ListNode.FromArray(l1);
        ListNode node2 = ListNode.FromArray(l2);

        ListNode result = _solution.AddTwoNumbers(node1, node2);
        int[] resultArr = ListNode.ToArray(result);

        Assert.Equal(output, resultArr);
    }

    [Fact]
    public void Test_3()
    {
        int[] l1 = [9, 9, 9, 9, 9, 9, 9];
        int[] l2 = [9, 9, 9, 9];
        int[] output = [8, 9, 9, 9, 0, 0, 0, 1];

        ListNode node1 = ListNode.FromArray(l1);
        ListNode node2 = ListNode.FromArray(l2);

        ListNode result = _solution.AddTwoNumbers(node1, node2);
        int[] resultArr = ListNode.ToArray(result);

        Assert.Equal(output, resultArr);
    }
}
