namespace Leetcode.Linked_List._138_Copy_List_with_Random_Pointer;

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if (head == null)
            return null;

        Dictionary<Node, Node> map = new();

        Node copyHead = new Node(head.val);
        map[head] = copyHead;

        Node? current1 = head.next;
        Node? current2 = copyHead;

        while (current1 != null)
        {
            current2.next = new Node(current1.val); ;
            map[current1] = current2.next;
            current2 = current2.next;
            current1 = current1.next;
        }

        current1 = head;
        current2 = copyHead;

        while (current2 != null)
        {
            Node currentRandom = null;

            if (current1?.random != null)
                currentRandom = map[current1.random];

            current2.random = currentRandom;

            current1 = current1?.next;
            current2 = current2?.next;
        }

        return copyHead;
    }
}
