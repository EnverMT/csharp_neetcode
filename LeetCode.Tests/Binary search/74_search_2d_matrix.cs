using Leetcode.Binary_Search._74_search_2d_matrix;

namespace Leetcode.Tests.Binary_search;

public class _74_search_2d_matrix
{
    private readonly Solution _solution;
    public _74_search_2d_matrix()
    {
        _solution = new Solution();
    }

    [Fact]
    public void Stack_search_2d_matrix_1()
    {
        bool result = _solution.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3);
        Assert.True(result);
    }

    [Fact]
    public void Stack_search_2d_matrix_2()
    {
        bool result = _solution.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13);
        Assert.False(result);
    }
}
