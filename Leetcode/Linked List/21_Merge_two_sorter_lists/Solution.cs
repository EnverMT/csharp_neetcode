namespace Leetcode.Linked_List._21_Merge_two_sorter_lists;

public class Solution
{
    private readonly ListNode head = new();
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode? tail = this.head;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            tail = tail.next;
        }

        if (list1 != null)
        {
            tail.next = list1;
        }
        else
        {
            tail.next = list2;
        }

        return this.head?.next;
    }
}
