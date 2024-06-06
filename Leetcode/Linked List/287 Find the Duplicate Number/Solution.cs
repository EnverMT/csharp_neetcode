namespace Leetcode.Linked_List._287_Find_the_Duplicate_Number;

public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int slow = 0, fast = 0;

        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];

            if (fast == slow)
                break;
        }

        int slow2 = 0;
        while (true)
        {
            slow2 = nums[slow2];
            slow = nums[slow];
            if (slow2 == slow)
                break;
        }

        return slow2;

    }
}
