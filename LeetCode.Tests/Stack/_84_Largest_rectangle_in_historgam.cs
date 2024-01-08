using Leetcode.Stack._84_Largest_rectangle_in_historgam;

namespace Leetcode.Tests.Stack;

public class _84_Largest_rectangle_in_historgam
{
    private readonly Solution solution;
    public _84_Largest_rectangle_in_historgam()
    {
        this.solution = new Solution();
    }

    [Fact]
    public void Stack_LargestRectangle()
    {
        Assert.Equal(10, solution.LargestRectangleArea([2, 1, 5, 6, 2, 3]));
    }

    [Fact]
    public void Stack_LargestRectangle_2()
    {
        Assert.Equal(4, solution.LargestRectangleArea([2, 4]));
    }
}
