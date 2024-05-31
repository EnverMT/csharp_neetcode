namespace Leetcode.SlidingWindow._424_Longest_Repeating_Character_Replacement;

public class Solution
{
    private readonly Dictionary<char, int> _frequence = [];

    public int CharacterReplacement(string s, int k)
    {
        int indexL = 0;
        int result = 0;

        for (int indexR = 0; indexR < s.Length; indexR++)
        {
            _frequence[s[indexR]] = _frequence.GetValueOrDefault(s[indexR]) + 1;

            while (indexR - indexL + 1 - GetMax() > k)
            {
                _frequence[s[indexL]] -= 1;
                indexL++;
            }

            result = Math.Max(result, indexR - indexL + 1);
        }

        GC.Collect();

        return result;
    }

    private int GetMax()
    {
        return _frequence.Values.DefaultIfEmpty().Max();
    }

}
