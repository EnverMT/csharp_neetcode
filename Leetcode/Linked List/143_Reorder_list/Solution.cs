namespace Leetcode.Linked_List._143_Reorder_list;

public class Solution
{
    public void ReorderList(ListNode head)
    {
        // find middle
        ListNode? slow = head;
        ListNode? fast = head?.next;

        while (fast != null && fast.next != null)
        {
            slow = slow?.next;
            fast = fast.next.next;
        }

        // reorder second half


        // merge first and second half
    }

    private ListNode Reverse(ListNode head)
    {
        ListNode tmp = new();
        while (head != null)
        {
            tmp = head;
            head = head.next;
            head.next = tmp;
        }

        return tmp;
    }
}
