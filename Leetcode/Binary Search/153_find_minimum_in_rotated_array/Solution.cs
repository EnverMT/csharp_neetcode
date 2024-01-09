namespace Leetcode.Binary_Search._153_find_minimum_in_rotated_array;

public class Solution
{
    public int FindMin(int[] nums)
    {
        int indexL = 0, indexR = nums.Length - 1, indexM = 0;

        while (indexL < indexR)
        {
            indexM = (indexL + indexR) / 2;

            if (nums[indexM] > nums[indexR])
            {
                indexL = indexM + 1;
            }
            else
            {
                indexR = indexM;
            }
        }
        GC.Collect();
        return nums[indexL];
    }
}
