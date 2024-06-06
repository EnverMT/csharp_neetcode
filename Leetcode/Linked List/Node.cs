namespace Leetcode.Linked_List;

public class Node
{
    public readonly int val;
    public Node? next = null;
    public Node? random = null;

    public int? index = 0;

    public Node(int value)
    {
        this.val = value;
    }

    public static Node FromArray(int?[][] array)
    {
        List<Node> nodes = new();

        Node head = new Node((int)array[0][0]!);
        nodes.Add(head);
        Node current = head;

        for (int i = 1; i < array.Length; i++)
        {
            current.next = new Node((int)array[i][0]!);
            current = current.next;
            nodes.Add(current);
        }

        for (Node? c = head; c != null; c = c.next)
            c.index = nodes.IndexOf(c);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i][1] != null)
                nodes[i].random = nodes.ElementAt((int)array[i][1]!);
        }

        return head;
    }

    public static int?[][] ToArray(Node? head)
    {
        List<int?[]> list = [];

        while (head != null)
        {
            list.Add([head.val, head.random?.index]);
            head = head.next;
        }

        return list.ToArray();
    }

    public override string ToString()
    {
        string index = "null";
        if (this.random != null)
            index = $"{this.random.index}";

        return $"[{this.val},{index}]";
    }
}
