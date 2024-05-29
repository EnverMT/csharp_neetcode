namespace Leetcode.Tree;

public class Base
{
    public TreeNode? ConvertArrayToTree(int[] array)
    {
        if (array.Length == 0)
            return null;

        TreeNode root = new TreeNode(array[0]);
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int i = 1;
        while (i < array.Length)
        {
            TreeNode current = queue.Dequeue();

            if (i < array.Length)
            {
                current.left = new TreeNode(array[i]);
                queue.Enqueue(current.left);
                i++;
            }

            if (i < array.Length)
            {
                current.right = new TreeNode(array[i]);
                queue.Enqueue(current.right);
                i++;
            }
        }

        return root;
    }

    public int[] ConvertTreeToArray(TreeNode root)
    {
        if (root == null)
            return [];

        List<int> result = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
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

        return result.ToArray();
    }

    // Method to print the tree in level order for verification
    public void PrintLevelOrder(TreeNode? root)
    {
        if (root == null)
            return;

        Queue<TreeNode> queue = new Queue<TreeNode>();
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
