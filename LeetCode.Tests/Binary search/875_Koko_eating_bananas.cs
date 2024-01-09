using Leetcode.Binary_Search._875_Koko_eating_bananas;

namespace Leetcode.Tests.Binary_search;

public class _875_Koko_eating_bananas
{
    private readonly Solution _solution;
    public _875_Koko_eating_bananas()
    {
        _solution = new Solution();
    }

    [Fact]
    public void Stack_Koko_eat_bananas_1()
    {
        int result = _solution.MinEatingSpeed([3, 6, 7, 11], 8);

        Assert.Equal(4, result);
    }

    [Fact]
    public void Stack_Koko_eat_bananas_2()
    {
        int result = _solution.MinEatingSpeed([30, 11, 23, 4, 20], 5);

        Assert.Equal(30, result);
    }

    [Fact]
    public void Stack_Koko_eat_bananas_3()
    {
        int result = _solution.MinEatingSpeed([30, 11, 23, 4, 20], 6);

        Assert.Equal(23, result);
    }

    [Fact]
    public void Stack_Koko_eat_bananas_4()
    {
        int result = _solution.MinEatingSpeed([312884470], 312884469);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Stack_Koko_eat_bananas_5()
    {
        int result = _solution.MinEatingSpeed([805306368, 805306368, 805306368], 1000000000);

        Assert.Equal(3, result);
    }
}
