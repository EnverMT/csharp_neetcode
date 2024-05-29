using Leetcode.Tree;

namespace Leetcode;

public class Program
{
    static void Main()
    {
        Base tree = new();

        int[] array = [];
        TreeNode? root = tree.ConvertArrayToTree(array);
        int[] arr = tree.ConvertTreeToArray(root!);
        //tree.PrintLevelOrder(arr);  // Output: 1 2 3 4 5 6 7

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
