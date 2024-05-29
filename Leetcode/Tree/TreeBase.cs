namespace Leetcode.Tree;

public class TreeBase
{
    public static TreeNode? ConvertArrayToTree(int?[] array)
    {
        if (array.Length == 0)
            return null;

        TreeNode? root = new(array[0]);
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        int i = 1;
        while (i < array.Length)
        {
            TreeNode current = queue.Dequeue();

            if (i < array.Length)
            {
                current.left = new TreeNode(array[i]);
                if (current.left.val != null)
                    queue.Enqueue(current.left);
                i++;
            }

            if (i < array.Length)
            {
                current.right = new TreeNode(array[i]);

                if (current.right.val != null)
                    queue.Enqueue(current.right);
                i++;
            }
        }

        return root;
    }

    public static int?[] ConvertTreeToArray(TreeNode? root)
    {
        if (root == null)
            return [];

        List<int?> result = [];
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();
            result.Add(current.val);

            if (current.left != null)
                queue.Enqueue(current.left);

            if (current.right != null)
                queue.Enqueue(current.right);
        }

        return [.. result];
    }

    // Method to print the tree in level order for verification
    public static void PrintLevelOrder(TreeNode? root)
    {
        if (root == null)
            return;

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();
            Console.WriteLine($"current val={current.val} left={current.left?.val}  right={current.right?.val}");

            if (current.left != null)
                queue.Enqueue(current.left);

            if (current.right != null)
                queue.Enqueue(current.right);
        }
    }
}
