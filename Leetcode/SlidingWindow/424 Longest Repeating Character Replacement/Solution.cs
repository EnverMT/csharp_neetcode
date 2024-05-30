namespace Leetcode.SlidingWindow._424_Longest_Repeating_Character_Replacement;

public class Solution
{
    private readonly Dictionary<char, int> _frequence = new();

    public int CharacterReplacement(string s, int k)
    {
        int indexL = 0;
        int result = 0;

        for (int indexR = 0; indexR < s.Length; indexR++)
        {
            if (_frequence.ContainsKey(s[indexR]))
                _frequence[s[indexR]] += 1;
            else
                _frequence.Add(s[indexR], 1);

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
        int max = 0;

        foreach (var item in _frequence)
        {
            if (max < item.Value)
                max = item.Value;
        }

        return max;
    }
}
