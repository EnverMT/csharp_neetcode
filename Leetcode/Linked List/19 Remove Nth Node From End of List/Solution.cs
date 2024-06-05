namespace Leetcode.Linked_List._19_Remove_Nth_Node_From_End_of_List;


public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new() { next = head };
        ListNode left = dummy;
        ListNode right = head;

        for (int i = 0; i < n; i++)
            right = right.next;


        while (right != null)
        {
            right = right.next;
            left = left.next;
        }

        left.next = left.next.next;

        return dummy.next;
    }
}
