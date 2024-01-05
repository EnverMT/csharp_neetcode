// https://leetcode.com/problems/3sum/
namespace Leetcode.Roadmap.Two_Pointer._13_3Sum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        int[] sortedNums = nums.OrderBy(x => x).ToArray();

        int indexA, indexL, indexR, sum;

        indexA = 0;
        while (indexA < sortedNums.Length - 2)
        {
            if (indexA > 0 && sortedNums[indexA] == sortedNums[indexA - 1])
            {
                indexA++;
                continue;
            }

            indexL = indexA + 1;
            indexR = sortedNums.Length - 1;

            while (indexL < indexR)
            {
                sum = sortedNums[indexA] + sortedNums[indexL] + sortedNums[indexR];

                if (sum > 0) { indexR--; }
                if (sum < 0) { indexL++; }
                if (sum == 0)
                {
                    res.Add(new List<int>() { sortedNums[indexA], sortedNums[indexL], sortedNums[indexR] });
                    indexL++;
                    while (indexL < indexR && sortedNums[indexL] == sortedNums[indexL - 1])
                    {
                        indexL++;
                    }
                }
            }
            indexA++;
        }

        return res;
    }
}
