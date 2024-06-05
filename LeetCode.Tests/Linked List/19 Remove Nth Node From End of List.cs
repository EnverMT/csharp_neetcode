﻿using Leetcode.Linked_List;
using Leetcode.Linked_List._19_Remove_Nth_Node_From_End_of_List;


namespace Leetcode.Tests.Linked_List;

public class _19_Remove_Nth_Node_From_End_of_List
{
    Solution _solution = new Solution();
    Base _base = new Base();

    [Fact]
    public void _19_Remove_Nth_Node_From_End_of_List_Test_1()
    {
        int[] head = [1, 2, 3, 4, 5];
        int n = 2;
        int[] output = [1, 2, 3, 5];

        ListNode listNode = _base.GetListNodesFromArray(head);
        ListNode resultNode = _solution.RemoveNthFromEnd(listNode, n);
        int[] result = _base.GetArrayFromList(resultNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _19_Remove_Nth_Node_From_End_of_List_Test_2()
    {
        int[] head = [1];
        int n = 1;
        int[] output = [];

        ListNode listNode = _base.GetListNodesFromArray(head);
        ListNode resultNode = _solution.RemoveNthFromEnd(listNode, n);
        int[] result = _base.GetArrayFromList(resultNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _19_Remove_Nth_Node_From_End_of_List_Test_3()
    {
        int[] head = [1, 2];
        int n = 1;
        int[] output = [1];

        ListNode listNode = _base.GetListNodesFromArray(head);
        ListNode resultNode = _solution.RemoveNthFromEnd(listNode, n);
        int[] result = _base.GetArrayFromList(resultNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _19_Remove_Nth_Node_From_End_of_List_Test_4()
    {
        int[] head = [1, 2, 3, 4];
        int n = 2;
        int[] output = [1, 2, 4];

        ListNode listNode = _base.GetListNodesFromArray(head);
        ListNode resultNode = _solution.RemoveNthFromEnd(listNode, n);
        int[] result = _base.GetArrayFromList(resultNode);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _19_Remove_Nth_Node_From_End_of_List_Test_5()
    {
        int[] head = [1, 2];
        int n = 2;
        int[] output = [2];

        ListNode listNode = _base.GetListNodesFromArray(head);
        ListNode resultNode = _solution.RemoveNthFromEnd(listNode, n);
        int[] result = _base.GetArrayFromList(resultNode);

        Assert.Equal(output, result);
    }
}
