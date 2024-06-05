namespace Leetcode.SlidingWindow._76_Minimum_Window_Substring;

public class Solution
{
    private Dictionary<char, int> _countT;
    private Dictionary<char, int> _window;

    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(t))
            return t;

        _countT = t.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
        _window = [];

        int have = 0;
        int need = _countT.Count;

        char chR, chL;

        int[] resultArr = [-1, -1];
        int resultLength = int.MaxValue;
        int indexL = 0;

        for (int indexR = 0; indexR < s.Length; indexR++)
        {
            chR = s[indexR];
            _window[chR] = _window.GetValueOrDefault(chR, 0) + 1;

            if (_countT.TryGetValue(chR, out int value) && _window[chR] == value)
                have++;

            while (have == need)
            {
                // update the result
                if (indexR - indexL + 1 < resultLength)
                {
                    resultArr = [indexL, indexR];
                    resultLength = indexR - indexL + 1;
                }

                // pop from left of our window
                chL = s[indexL];
                _window[chL] -= 1;

                if (_countT.ContainsKey(chL) && _window[chL] < _countT[chL])
                {
                    have--;
                }

                indexL++;
            }
        }

        int l = resultArr[0];
        int r = resultArr[1];

        return resultLength != int.MaxValue ? s[l..(r + 1)] : "";
    }
}
