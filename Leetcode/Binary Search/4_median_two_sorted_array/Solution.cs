namespace Leetcode.Binary_Search._4_median_two_sorted_array;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length) return this.FindMedianSortedArrays(nums2, nums1);

        int totalLength = nums1.Length + nums2.Length;
        int indexL = 0;
        int indexR = nums1.Length - 1;
        int i, j;
        float Aleft, Aright, Bleft, Bright;

        while (true)
        {
            i = (int)Math.Floor((indexL + indexR) / 2.0);
            j = totalLength / 2 - i - 2;

            Aleft = (i >= 0) ? nums1[i] : float.NegativeInfinity;
            Aright = (i + 1 < nums1.Length) ? nums1[i + 1] : float.PositiveInfinity;
            Bleft = (j >= 0) ? nums2[j] : float.NegativeInfinity;
            Bright = (j + 1 < nums2.Length) ? nums2[j + 1] : float.PositiveInfinity;

            if (Aleft <= Bright && Bleft < Aright)
            {
                if (int.IsOddInteger(totalLength)) return Math.Min(Aright, Bright);

                return (float.Max(Aleft, Bleft) + float.Min(Aright, Bright)) / 2;
            }

            if (Aleft > Bright)
            {
                indexR = i - 1;
            }
            else
            {
                indexL = i + 1;
            }
        }
    }
}
