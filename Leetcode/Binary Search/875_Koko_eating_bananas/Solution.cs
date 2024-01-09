namespace Leetcode.Binary_Search._875_Koko_eating_bananas;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int indexL = 1;
        int indexR = piles.Max();

        int eatSpeed, totalTime;
        int result = indexR;

        while (indexL <= indexR)
        {
            eatSpeed = (indexL + indexR) / 2;
            totalTime = this.GetEatHours(piles, eatSpeed);
            if (totalTime < 0) break;


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

    private int GetEatHours(int[] piles, int eatSpeed)
    {
        double totalTime = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            totalTime += Math.Ceiling((double)piles[i] / (double)eatSpeed);
        }
        return (int)totalTime;
    }
}
