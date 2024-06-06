namespace Leetcode.Linked_List;


public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public static ListNode FromArray(int[] array)
    {
        ListNode head = new(array[0]);
        ListNode curr = head;
        for (int i = 1; i < array.Length; i++)
        {
            curr.next = new(array[i]);
            curr = curr.next;
        }
        return head;
    }

    public static int[] ToArray(ListNode head)
    {
        List<int> list = [];
        while (head != null)
        {
            list.Add(head.val);
            head = head.next!;
        }
        return list.ToArray();
    }

    public static string ArrayToString(int[] array)
    {
        return $"[{string.Join(",", array)}]";
    }
}

