using Leetcode.Stack._853_Car_fleet;

namespace Leetcode.Tests.Stack;

public class _853_Car_fleet
{
    private readonly Solution _solution;
    public _853_Car_fleet()
    {
        this._solution = new Solution();
    }

    [Fact]
    public void Stack_CarFleet_1()
    {
        Assert.Equal(3, this._solution.CarFleet(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]));
    }

    [Fact]
    public void Stack_CarFleet_2()
    {
        Assert.Equal(1, this._solution.CarFleet(10, [3], [3]));
    }

    [Fact]
    public void Stack_CarFleet_3()
    {
        Assert.Equal(1, this._solution.CarFleet(100, [0, 2, 4], [4, 2, 1]));
    }

}
