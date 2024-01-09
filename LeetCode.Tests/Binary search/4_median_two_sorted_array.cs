using Leetcode.Binary_Search._4_median_two_sorted_array;

namespace Leetcode.Tests.Binary_search;

public class _4_median_two_sorted_array
{
    private readonly Solution solution;
    public _4_median_two_sorted_array()
    {
        solution = new Solution();
    }

    [Fact]
    public void BinarySearch_Median_1()
    {
        double result = solution.FindMedianSortedArrays([1, 3], [2]);

        Assert.Equal(2.0, result);
    }

    [Fact]
    public void BinarySearch_Median_2()
    {
        double result = solution.FindMedianSortedArrays([1, 2], [3, 4]);

        Assert.Equal(2.5, result);
    }
}
