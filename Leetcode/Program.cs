using Leetcode.Tree;

namespace Leetcode;

public class Program
{
    static void Main()
    {
        Base tree = new ();

        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        TreeNode? root = tree.ConvertArrayToTree(array);
        tree.PrintLevelOrder(root);  // Output: 1 2 3 4 5 6 7
    }
}
