namespace Leetcode.SlidingWindow._3_Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    Queue<char> queue = new();

    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            while (queue.Contains(s.ElementAt(i)))
            {
                queue.Dequeue();
            }

            queue.Enqueue(s.ElementAt(i));

            if (maxLength < queue.Count)
                maxLength = queue.Count;
        }

        GC.Collect();

        return maxLength;
    }
}