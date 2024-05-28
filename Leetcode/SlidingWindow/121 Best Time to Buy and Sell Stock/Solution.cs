namespace Leetcode.SlidingWindow._121_Best_Time_to_Buy_and_Sell_Stock;


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int profit;
        int indexL = 0, indexR = 1;

        while (indexR <= prices.Length - 1)
        {
            if (prices[indexL] > prices[indexR])
                indexL = indexR;

            profit = prices[indexR] - prices[indexL];

            if (maxProfit < profit)
                maxProfit = profit;

            indexR++;
        }

        return maxProfit;
    }
}