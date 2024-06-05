using Leetcode.SlidingWindow._239._Sliding_Window_Maximum;


namespace Leetcode.Tests.Sliding_window;

public class _239_Sliding_Window_Maximum
{
    Solution _solution = new Solution();

    [Fact]
    public void _239_Sliding_Window_Maximum_Test_1()
    {
        int[] nums = [1, 3, -1, -3, 5, 3, 6, 7];
        int k = 3;
        int[] output = [3, 3, 5, 5, 6, 7];

        int[] result = _solution.MaxSlidingWindow(nums, k);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _239_Sliding_Window_Maximum_Test_2()
    {
        int[] nums = [1];
        int k = 1;
        int[] output = [1];

        int[] result = _solution.MaxSlidingWindow(nums, k);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _239_Sliding_Window_Maximum_Test_3()
    {
        int[] nums = [1, 2, 1, 0, 4, 2, 6];
        int k = 3;
        int[] output = [2, 2, 4, 4, 6];

        int[] result = _solution.MaxSlidingWindow(nums, k);

        Assert.Equal(output, result);
    }
}
