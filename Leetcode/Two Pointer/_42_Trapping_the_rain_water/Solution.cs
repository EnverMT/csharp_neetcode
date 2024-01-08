namespace Leetcode.Two_Pointer._42_Trapping_the_rain_water;

public class Solution
{
    public int Trap(int[] height)
    {
        int sum = 0;

        int indexL = 0;
        int indexR = height.Length - 1;

        int maxLeft = height[indexL];
        int maxRight = height[indexR];

        while (indexL < indexR)
        {
            if (maxLeft <= maxRight)
            {
                indexL++;
                if (maxLeft < height[indexL])
                {
                    maxLeft = height[indexL];
                }
                else
                {
                    sum += maxLeft - height[indexL];
                }
            }
            else
            {
                indexR--;
                if (maxRight < height[indexR])
                {
                    maxRight = height[indexR];
                }
                else
                {
                    sum += maxRight - height[indexR];
                }
            }
        }
        GC.Collect();
        return sum;
    }
}
