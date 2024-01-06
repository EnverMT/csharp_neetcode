using Leetcode.Interface;

namespace Leetcode.Roadmap.Binary_Search._704_Binary_search;

internal class Test : Solution, ITest
{
    private int caseNumber = 1;

    public void TestCases()
    {
        Console.WriteLine($"704. Binary search{Environment.NewLine}");
        this.Case([-1, 0, 3, 5, 9, 12], 9, 4);
        this.Case([-1, 0, 3, 5, 9, 12], 2, -1);
    }

    private bool Case(int[] input, int target, int expectedResult)
    {
        int result = this.Search(input, target);

        Console.WriteLine($"Case #{this.caseNumber}");
        Console.WriteLine($"input = [{string.Join(",", input)}]");
        Console.WriteLine($"result          = {result}");
        Console.WriteLine($"expected result = {expectedResult}");
        Console.WriteLine($"is correct: {expectedResult == result} {Environment.NewLine}");

        this.caseNumber++;
        return expectedResult == result;
    }
}
