namespace Leetcode;

using Linked_List;

public class Program
{
    static void Main()
    {
        int?[][] head = [[7, null], [13, 0], [11, 4], [10, 2], [1, 0]];

        Node node = Node.FromArray(head);
        int?[][] res = Node.ToArray(node);
        Console.WriteLine(res);
    }
}
