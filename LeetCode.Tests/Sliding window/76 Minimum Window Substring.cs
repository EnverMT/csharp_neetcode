using Leetcode.SlidingWindow._76_Minimum_Window_Substring;

namespace Leetcode.Tests.Sliding_window;

public class _76_Minimum_Window_Substring
{
    private readonly Solution solution = new Solution();

    [Fact]
    public void _76_Minimum_Window_Substring_Test_1()
    {
        string s = "ADOBECODEBANC";
        string t = "ABC";
        string output = "BANC";

        string result = solution.MinWindow(s, t);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _76_Minimum_Window_Substring_Test_2()
    {
        string s = "a";
        string t = "a";
        string output = "a";

        string result = solution.MinWindow(s, t);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _76_Minimum_Window_Substring_Test_3()
    {
        string s = "a";
        string t = "aa";
        string output = "";

        string result = solution.MinWindow(s, t);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _76_Minimum_Window_Substring_Test_4()
    {
        string s = "OUZODYXAZV";
        string t = "XYZ";
        string output = "YXAZ";

        string result = solution.MinWindow(s, t);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _76_Minimum_Window_Substring_Test_5()
    {
        string s = "xyz";
        string t = "xyz";
        string output = "xyz";

        string result = solution.MinWindow(s, t);

        Assert.Equal(output, result);
    }

    [Fact]
    public void _76_Minimum_Window_Substring_Test_6()
    {
        string s = "x";
        string t = "xy";
        string output = "";

        string result = solution.MinWindow(s, t);

        Assert.Equal(output, result);
    }
}
