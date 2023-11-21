using Leetcode.Interface;

namespace Leetcode.Roadmap.Stack._20_Valid_parentheses;

internal class Test : ITest
{
    public void TestCases()
    {
        Solution sol = new Solution();
        Console.WriteLine($"isValid({sol.IsValid("()")}) for ()");
        Console.WriteLine($"isValid({sol.IsValid("()[]{}{}(())")}) for 2");
        Console.WriteLine($"notisValid({sol.IsValid("()[]{{}(())")}) for 2");
    }
}
