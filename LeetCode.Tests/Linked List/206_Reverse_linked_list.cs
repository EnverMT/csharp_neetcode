using Leetcode.Linked_List._206_Reverse_linked_list;

namespace Leetcode.Tests.Linked_List;

public class _206_Reverse_linked_list
{
    private readonly Solution _solution;
    public _206_Reverse_linked_list()
    {
        this._solution = new Solution();
    }

    [Fact]
    public void LinkedList_ReverseHead_1()
    {
        ListNode headNode = new(1);

        int lastIndex = 6;
        ListNode currentNode = headNode;
        for (int i = 2; i < lastIndex; i++)
        {
            ListNode newNode = new(i);
            currentNode.next = newNode;
            currentNode = newNode;
        }

        this._solution.ReverseList(headNode);
    }    
}
