using Leetcode.Binary_Search._153_find_minimum_in_rotated_array;

namespace Leetcode.Tests.Binary_search;

public class _153_find_minimum_in_rotated_array
{
    private readonly Solution solution;
    public _153_find_minimum_in_rotated_array()
    {
        this.solution = new Solution();
    }

    [Fact]
    public void BinarySearch_MinInRotatedArray_1()
    {
        int result = solution.FindMin([3, 4, 5, 1, 2]);

        Assert.Equal(1, result);
    }

    [Fact]
    public void BinarySearch_MinInRotatedArray_2()
    {
        int result = solution.FindMin([4, 5, 6, 7, 0, 1, 2]);

        Assert.Equal(0, result);
    }

    [Fact]
    public void BinarySearch_MinInRotatedArray_3()
    {
        int result = solution.FindMin([11, 13, 15, 17]);

        Assert.Equal(11, result);
    }

    [Fact]
    public void BinarySearch_MinInRotatedArray_4()
    {
        int result = solution.FindMin([2,1]);

        Assert.Equal(1, result);
    }


}
