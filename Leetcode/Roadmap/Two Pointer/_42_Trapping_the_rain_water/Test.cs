using Leetcode.Interface;

namespace Leetcode.Roadmap.Two_Pointer._42_Trapping_the_rain_water;

internal class Test : Solution, ITest
{
    private int caseNumber = 1;

    public void TestCases()
    {
        Console.WriteLine("42. Trapping the rain water\r\n");
        this.Case([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1], 6);
        this.Case([4, 2, 0, 3, 2, 5], 9);
    }

    private bool Case(int[] heights, int expectedResult)
    {
        int result = this.Trap(heights);

        Console.WriteLine($"Case #{this.caseNumber}");
        Console.WriteLine($"input = [{string.Join(",", heights)}]");
        Console.WriteLine($"result          = {result}");
        Console.WriteLine($"expected result = {expectedResult}");
        Console.WriteLine($"is correct: {expectedResult == result} {Environment.NewLine}");

        this.caseNumber++;
        return expectedResult == result;
    }
}
