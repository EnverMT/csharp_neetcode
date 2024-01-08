using Leetcode.Stack._20_Valid_parentheses;

namespace Leetcode.Tests.Stack;


public class _20_Valid_parentheses
{
    [Fact]
    public void Stack_ValidParentheses()
    {
        Solution solution = new Solution();

        Assert.True(solution.IsValid("()"));
        Assert.True(solution.IsValid("()[]{}"));
        Assert.False(solution.IsValid("(]"));
    }
}
