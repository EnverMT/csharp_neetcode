namespace Leetcode.Stack._84_Largest_rectangle_in_historgam;

public class Solution
{
    private Stack<Histogram> stack = new();
    private int maxArea = 0;
    public int LargestRectangleArea(int[] heights)
    {
        for (int i = 0; i < heights.Length; i++)
        {
            int start = i;
            while (stack.Count > 0 && stack.Peek().height >= heights[i])
            {
                Histogram his = stack.Pop();
                maxArea = Math.Max(maxArea, his.height * (i - his.index));
                start = his.index;
            }

            stack.Push(new Histogram(start, heights[i]));
        }

        foreach (Histogram h in stack)
        {
            maxArea = Math.Max(maxArea, h.height * (heights.Length - h.index));
        }

        return maxArea;
    }
}

public struct Histogram
{
    public int index;
    public int height;

    public Histogram(int index, int height)
    {
        this.index = index;
        this.height = height;
    }
}