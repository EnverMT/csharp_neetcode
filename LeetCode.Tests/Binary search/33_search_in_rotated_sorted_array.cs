using Leetcode.Binary_Search._33_search_in_rotated_sorted_array;

namespace Leetcode.Tests.Binary_search;

public class _33_search_in_rotated_sorted_array
{
    private readonly Solution solution;
    public _33_search_in_rotated_sorted_array()
    {
        this.solution = new Solution();
    }

    [Fact]
    public void BinarySearch_SearchInRotatedArray_1()
    {
        int result = this.solution.Search([4, 5, 6, 7, 0, 1, 2], 0);

        Assert.Equal(4, result);
    }

    [Fact]
    public void BinarySearch_SearchInRotatedArray_2()
    {
        int result = this.solution.Search([4, 5, 6, 7, 0, 1, 2], 3);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_SearchInRotatedArray_3()
    {
        int result = this.solution.Search([1], 0);

        Assert.Equal(-1, result);
    }
}
