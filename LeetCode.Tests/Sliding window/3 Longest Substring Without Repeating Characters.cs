using Leetcode.SlidingWindow._3_Longest_Substring_Without_Repeating_Characters;

namespace Leetcode.Tests.Sliding_window;

public class _3_Longest_Substring_Without_Repeating_Characters
{
    private readonly Solution solution = new();

    [Fact]
    public void _3_Longest_Substring_Without_Repeating_Characters_1()
    {
        string s = "zxczxc";
        int result = 3;

        Assert.Equal(result, solution.LengthOfLongestSubstring(s));
    }

    [Fact]
    public void _3_Longest_Substring_Without_Repeating_Characters_2()
    {
        string s = "abcabcbb";
        int result = 3;

        Assert.Equal(result, solution.LengthOfLongestSubstring(s));
    }

    [Fact]
    public void _3_Longest_Substring_Without_Repeating_Characters_3()
    {
        string s = "bbbbb";
        int result = 1;

        Assert.Equal(result, solution.LengthOfLongestSubstring(s));
    }

    [Fact]
    public void _3_Longest_Substring_Without_Repeating_Characters_4()
    {
        string s = "pwwkew";
        int result = 3;

        Assert.Equal(result, solution.LengthOfLongestSubstring(s));
    }
}
