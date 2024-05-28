namespace Leetcode.Linked_List;

public class Base
{
    private List<ListNode> list = new();

    public Base()
    {
    }

    public ListNode GetListNodesFromArray(int[] array)
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

    public int[] GetArrayFromList(ListNode head)
    {
        List<int> list = new();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next!;
        }
        return list.ToArray();
    }

    public string ArrayToString(int[] array)
    {
        return $"[{string.Join(",", array)}]";
    }
}
