namespace Leetcode.Roadmap.Stack._84_Largest_rectangle_in_historgam;
public class Solution
{
    private Stack<Histogram> stack = new();
    private int maxArea = 0;
    public int LargestRectangleArea(int[] heights)
    {
        Histogram? h;
        for (int i = 0; i < heights.Length; i++)
        {
            h = null;
            while (stack.Count > 0 && stack.Peek().height >= heights[i])
            {
                int area = heights[i] * (i - stack.Peek().index + 1);
                if (maxArea < area) maxArea = area;
                h = stack.Pop();
            }

            stack.Push(new Histogram(h?.index ?? i, heights[i]));
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