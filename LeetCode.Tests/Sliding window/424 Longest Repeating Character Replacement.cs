using Leetcode.SlidingWindow._424_Longest_Repeating_Character_Replacement;

namespace Leetcode.Tests.Sliding_window;

public class _424_Longest_Repeating_Character_Replacement
{
    private readonly Solution _solution = new();

    [Fact]
    public void _424_Longest_Repeating_Character_Replacement_Test_1()
    {
        string s = "ABAB";
        int k = 2;
        int expectedOutput = 4;

        Assert.Equal(expectedOutput, _solution.CharacterReplacement(s, k));
    }

    [Fact]
    public void _424_Longest_Repeating_Character_Replacement_Test_2()
    {
        string s = "AABABBA";
        int k = 1;
        int expectedOutput = 4;

        Assert.Equal(expectedOutput, _solution.CharacterReplacement(s, k));
    }

    [Fact]
    public void _424_Longest_Repeating_Character_Replacement_Test_3()
    {
        string s = "XYYX";
        int k = 2;
        int expectedOutput = 4;

        Assert.Equal(expectedOutput, _solution.CharacterReplacement(s, k));
    }

    [Fact]
    public void _424_Longest_Repeating_Character_Replacement_Test_4()
    {
        string s = "AAABABB";
        int k = 1;
        int expectedOutput = 5;

        Assert.Equal(expectedOutput, _solution.CharacterReplacement(s, k));
    }
}
