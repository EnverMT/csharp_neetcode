namespace Leetcode.Linked_List._206_Reverse_linked_list;

public class Solution
{
    private ListNode? previous;
    private ListNode? current;
    private ListNode? next;

    public ListNode ReverseList(ListNode head)
    {
        this.current = head;

        while (current != null)
        {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous!;
    }
}
