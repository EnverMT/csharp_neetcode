namespace Leetcode.Binary_Search._875_Koko_eating_bananas;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int indexL = 1;
        int indexR = piles.Max();

        int eatSpeed;
        long totalTime;
        int result = indexR;

        while (indexL <= indexR)
        {
            eatSpeed = (indexL + indexR) / 2;
            totalTime = this.GetEatHours(piles, eatSpeed);

            if (totalTime <= h)
            {
                result = eatSpeed;
                indexR = eatSpeed - 1;
            }
            if (totalTime > h) { indexL = eatSpeed + 1; }

        }
        GC.Collect();
        return result;
    }

    private long GetEatHours(int[] piles, int eatSpeed)
    {
        long totalTime = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            totalTime += (long)Math.Ceiling((double)piles[i] / (double)eatSpeed);
        }
        return totalTime;
    }
}
