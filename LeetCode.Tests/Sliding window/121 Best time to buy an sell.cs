using Leetcode.SlidingWindow._121_Best_Time_to_Buy_and_Sell_Stock;

namespace Leetcode.Tests.Sliding_window;

public class _121_Best_time_to_buy_an_sell
{
    private readonly Solution solution = new();

    [Fact]
    public void LinkedList_143_Reorder_list_Test_1()
    {
        Assert.Equal(2, solution.MaxProfit([1, 2, 3]));
    }

    [Fact]
    public void LinkedList_143_Reorder_list_Test_2()
    {
        Assert.Equal(5, solution.MaxProfit([1, 2, 3, 4, 5, 6]));
    }

    [Fact]
    public void LinkedList_143_Reorder_list_Test_3()
    {
        Assert.Equal(5, solution.MaxProfit([7, 1, 5, 2, 6, 0]));
    }

    [Fact]
    public void LinkedList_143_Reorder_list_Test_4()
    {
        Assert.Equal(4, solution.MaxProfit([7, 3, 5, 2, 6, 0]));
    }
}
