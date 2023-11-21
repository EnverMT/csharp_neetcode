using Leetcode.Interface;

namespace Leetcode.Roadmap.Stack._84_Largest_rectangle_in_historgam;

internal class Test : ITest
{
    public void TestCases()
    {
        int[] heights = [2, 1, 5, 6, 2, 3];
        Solution solution = new Solution();
        Console.WriteLine(solution.LargestRectangleArea(heights));
    }
}
