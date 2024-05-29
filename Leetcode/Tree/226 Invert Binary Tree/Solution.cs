namespace Leetcode.Tree._226_Invert_Binary_Tree;

public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root.left == null && root.right == null)
            return root;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            // Swap the left and right children
            TreeNode temp = current.left;
            current.left = current.right;
            current.right = temp;

            if (current.left != null)
                queue.Enqueue(current.left);

            if (current.right != null)
                queue.Enqueue(current.right);
        }

        return root;
    }
}
