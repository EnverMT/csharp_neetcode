using Leetcode.Interface;


namespace Leetcode.Roadmap.Two_Pointer._13_3Sum;

internal class Test : Solution, ITest
{
    private int caseNum = 0;

    public void TestCases()
    {
        this.Case([-1, 0, 1, 2, -1, -4], [[-1, -1, 2], [-1, 0, 1]]);
        this.Case([0, 1, 1], []);
        this.Case([0, 0, 0], [[0, 0, 0]]);
        this.Case([0, 0, 0, 0], [[0, 0, 0]]);
    }

    private void Case(int[] nums, IList<IList<int>> output)
    {
        this.caseNum++;
        IList<IList<int>> result = this.ThreeSum(nums);

        Console.WriteLine($"Case #{caseNum}");
        Console.WriteLine($"input = [{string.Join(',', nums)}]");
        Console.WriteLine($"expected = {this.ListListToString(output)}");
        Console.WriteLine($"result   = {this.ListListToString(result)}");

        Console.WriteLine(Environment.NewLine);
    }

    private string ListListToString(IList<IList<int>> list)
    {
        List<string> list_inter = new List<string>();

        foreach (var itemList in list)
        {
            list_inter.Add($"[{string.Join(",", itemList)}]");
        }

        return $"[{string.Join(',', list_inter)}]";
    }
}
