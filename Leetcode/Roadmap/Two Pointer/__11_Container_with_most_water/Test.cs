using Leetcode.Interface;

namespace Leetcode.Roadmap.Two_Pointer.__11_Container_with_most_water;

internal class Test : Solution, ITest
{
    private int caseNumber = 1;

    public void TestCases()
    {
        Console.WriteLine("11. Container With Most Water\r\n");
        this.Case([1, 8, 6, 2, 5, 4, 8, 3, 7], 49);
        this.Case([1, 1], 1);
        this.Case([2, 3, 4, 5, 18, 17, 6], 17);
    }

    private bool Case(int[] heights, int expectedResult)
    {
        int result = this.MaxArea(heights);

        Console.WriteLine($"Case #{this.caseNumber}");
        Console.WriteLine($"input = [{string.Join(",", heights)}]");
        Console.WriteLine($"result          = {result}");
        Console.WriteLine($"expected result = {expectedResult}");
        Console.WriteLine($"is correct: {expectedResult == result} {Environment.NewLine}");

        this.caseNumber++;
        return expectedResult == result;
    }
}
