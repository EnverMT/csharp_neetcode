using Leetcode.SlidingWindow._567_Permutation_in_String;


namespace Leetcode.Tests.Sliding_window;

public class _567_Permutation_in_String
{
    private readonly Solution _solution = new();

    [Fact]
    public void _567_Permutation_in_String_Test_1()
    {
        string s1 = "ab";
        string s2 = "eidbaooo";
        bool output = true;

        Assert.Equal(output, _solution.CheckInclusion(s1, s2));
    }

    [Fact]
    public void _567_Permutation_in_String_Test_2()
    {
        string s1 = "ab";
        string s2 = "eidboaoo";
        bool output = false;

        Assert.Equal(output, _solution.CheckInclusion(s1, s2));
    }

    [Fact]
    public void _567_Permutation_in_String_Test_3()
    {
        string s1 = "abc";
        string s2 = "lecabee";
        bool output = true;

        Assert.Equal(output, _solution.CheckInclusion(s1, s2));
    }

    [Fact]
    public void _567_Permutation_in_String_Test_4()
    {
        string s1 = "abc";
        string s2 = "lecaabee";
        bool output = false;

        Assert.Equal(output, _solution.CheckInclusion(s1, s2));
    }

    [Fact]
    public void _567_Permutation_in_String_Test_5()
    {
        string s1 = "adc";
        string s2 = "dcda";
        bool output = true;

        Assert.Equal(output, _solution.CheckInclusion(s1, s2));
    }
}
