namespace Leetcode.Linked_List._143_Reorder_list;

public class Solution
{
    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null)
            return;

        // find middle
        ListNode? slow = head;
        ListNode? fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // reverse second half
        slow.next = ReverseList(slow.next);

        // merge first and second half
        ListNode? head1 = head;
        ListNode? head2 = slow.next;
        slow.next = null;

        ListNode? next1, next2;

        while (head1 != null && head2 != null)
        {
            next1 = head1.next;
            next2 = head2.next;

            head1.next = head2;
            head2.next = next1;

            head1 = next1;
            head2 = next2;
        }
    }

    private ListNode ReverseList(ListNode head)
    {
        ListNode? current = head;
        ListNode? next;
        ListNode? previous = null;

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
