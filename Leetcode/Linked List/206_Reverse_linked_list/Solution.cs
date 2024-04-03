namespace Leetcode.Linked_List._206_Reverse_linked_list;

public class Solution
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode? previous = null;
        ListNode? current = head;
        ListNode? next;

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
