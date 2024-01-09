namespace Leetcode.Binary_Search._33_search_in_rotated_sorted_array;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, m;

        while (l <= r)
        {
            m = (l + r) / 2;
            if (nums[m] == target) return m;

            if (nums[l] <= nums[m])
            { // left half sorted
                if (nums[l] <= target && target <= nums[m])
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            else
            { // right half sorted
                if (nums[m] <= target && target <= nums[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
        }

        return -1;
    }
}
