namespace Leetcode.Linked_List._2_Add_Two_Numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode node1, ListNode node2)
    {
        ListNode head = new(0);
        ListNode current = head;

        int overflow = 0;

        while (node1 != null || node2 != null || overflow > 0)
        {
            int n1 = node1?.val ?? 0;
            int n2 = node2?.val ?? 0;
            int n = n1 + n2 + overflow;
            overflow = n / 10;

            ListNode nextNode = new ListNode(n % 10);

            current.next = nextNode;
            current = current.next;

            node1 = node1?.next;
            node2 = node2?.next;
        }

        return head.next;
    }
}