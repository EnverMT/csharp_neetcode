namespace Leetcode.SlidingWindow._567_Permutation_in_String;

public class Solution
{
    private Dictionary<char, int>? _dict1;
    private readonly Dictionary<char, int> _dict2 = new();
    private int _matches = 0;

    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        _dict1 = s1.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

        int indexL = 0;

        for (int indexR = 0; indexR < s2.Length; indexR++)
        {
            _dict2[s2[indexR]] = _dict2.GetValueOrDefault(s2[indexR], 0) + 1;

            if (indexR - indexL + 1 > s1.Length)
            {
                _dict2[s2[indexL]] -= 1;

                if (_dict2[s2[indexL]] == 0)
                    _dict2.Remove(s2[indexL]);

                indexL++;
            }

            if (IsEqual(_dict1, _dict2))
                return true;
        }

        return false;
    }

    private bool IsEqual(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        return dict1.Count == dict2.Count &&
               dict1.All(item => dict2.TryGetValue(item.Key, out int value) && value == item.Value);
    }
}