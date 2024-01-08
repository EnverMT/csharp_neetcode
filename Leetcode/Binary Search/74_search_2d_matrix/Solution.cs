namespace Leetcode.Binary_Search._74_search_2d_matrix;

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Any(x => x.Contains(target))) return true;

        return false;
    }
}
