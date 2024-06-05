namespace Leetcode.SlidingWindow._239._Sliding_Window_Maximum;

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int indexL = 0;
        List<int> result = [];
        LinkedList<int> q = new();

        for (int indexR = 0; indexR < nums.Length; indexR++)
        {
            while (q.Count > 0 && nums[q.Last.Value] < nums[indexR])
            {
                q.RemoveLast();
            }

            q.AddLast(indexR);

            if (indexL > q.First?.Value)
                q.RemoveFirst();

            if (indexR + 1 >= k)
            {
                result.Add(nums[q.First.Value]);
                indexL++;
            }
        }

        return result.ToArray();
    }
}
