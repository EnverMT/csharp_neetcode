using Leetcode.Linked_List._287_Find_the_Duplicate_Number;


namespace Leetcode.Tests.Linked_List;

public class _287_Find_the_Duplicate_Number
{
    private readonly Solution solution = new();

    [Fact]
    public void Test_1()
    {
        int[] nums = [1, 3, 4, 2, 2];
        int output = 2;

        int result = solution.FindDuplicate(nums);

        Assert.Equal(output, result);
    }

    [Fact]
    public void Test_2()
    {
        int[] nums = [3, 1, 3, 4, 2];
        int output = 3;

        int result = solution.FindDuplicate(nums);

        Assert.Equal(output, result);
    }

    [Fact]
    public void Test_3()
    {
        int[] nums = [3, 3, 3, 3, 3];
        int output = 3;

        int result = solution.FindDuplicate(nums);

        Assert.Equal(output, result);
    }
}
