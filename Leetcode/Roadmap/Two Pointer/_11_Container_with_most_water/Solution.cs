namespace Leetcode.Roadmap.Two_Pointer._11_Container_with_most_water;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0, area;

        int indexL = 0;
        int indexR = height.Length - 1;

        while (indexL < indexR)
        {
            area = (indexR - indexL) * int.Min(height[indexL], height[indexR]);
            maxArea = int.Max(maxArea, area);

            if (height[indexL] <= height[indexR])
            {
                indexL++;
            }
            else
            {
                indexR--;
            }
        }

        GC.Collect();
        return maxArea;
    }
}