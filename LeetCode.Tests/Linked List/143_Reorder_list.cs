using Leetcode.Linked_List;
using Leetcode.Linked_List._143_Reorder_list;

namespace Leetcode.Tests.Linked_List;

public class _143_Reorder_list
{
    private readonly Solution _solution = new();

    [Fact]
    public void LinkedList_143_Reorder_list_test_1()
    {
        ListNode head = ListNode.FromArray([1, 2, 3, 4, 5]);
        int[] expected = [1, 5, 2, 4, 3];

        _solution.ReorderList(head);

        int[] reordered = ListNode.ToArray(head);
        Assert.Equal(expected, reordered);
    }

    [Fact]
    public void LinkedList_143_Reorder_list_test_2()
    {
        ListNode head = ListNode.FromArray([1, 2, 3, 4]);
        int[] expected = [1, 4, 2, 3];

        _solution.ReorderList(head);

        int[] reordered = ListNode.ToArray(head);
        Assert.Equal(expected, reordered);
    }
}