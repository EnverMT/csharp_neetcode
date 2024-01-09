namespace Leetcode.Binary_Search._981_Time_based_kv_store;

public class TimeMap
{
    private readonly Dictionary<string, List<(int, string)>> timeMap; // key : tuple (timestamp, value)
    public TimeMap()
    {
        this.timeMap = new();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (this.timeMap.ContainsKey(key))
        {
            this.timeMap[key].Add((timestamp, value));
        }
        else
        {
            this.timeMap[key] = new() {
                { (timestamp, value) }
            };
        }
    }

    public string Get(string key, int timestamp)
    {
        if (!this.timeMap.ContainsKey(key)) return string.Empty;

        List<(int Timestamp, string Value)> values = this.timeMap[key];

        int l = 0, m, r = values.Count - 1;

        while (l <= r)
        {
            m = (l + r) / 2;
            if (values[m].Timestamp == timestamp) return values[m].Value;

            if (values[m].Timestamp > timestamp)
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        if (l == 0) return string.Empty;

        return values[l - 1].Value;
    }
}