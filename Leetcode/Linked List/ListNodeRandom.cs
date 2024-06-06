namespace Leetcode.Linked_List;

public class ListNodeRandom(int val = 0, ListNode? next = null, ListNodeRandom? random = null) : ListNode(val, next)
{
    public ListNodeRandom? random = random;
}
