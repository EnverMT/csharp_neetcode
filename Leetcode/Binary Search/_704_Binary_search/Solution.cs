namespace Leetcode.Binary_Search._704_Binary_search;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int indexL = 0;
        int indexR = nums.Length - 1;
        int indexM;

        while (indexL <= indexR)
        {
            indexM = indexL + (indexR - indexL) / 2;

            if (nums[indexM] == target) return indexM;

            if (nums[indexM] < target)
            {
                indexL = indexM + 1;
            }
            else
            {
                indexR = indexM - 1;
            }
        }
        GC.Collect();
        return -1;
    }
}