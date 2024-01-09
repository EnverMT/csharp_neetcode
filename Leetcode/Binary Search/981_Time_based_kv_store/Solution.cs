namespace Leetcode.Binary_Search._981_Time_based_kv_store;

public class TimeMap
{
    private readonly Dictionary<string, Dictionary<int, string>> timeMap;
    public TimeMap()
    {
        this.timeMap = new();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (this.timeMap.ContainsKey(key))
        {
            this.timeMap[key].Add(timestamp, value);
        }
        else
        {
            this.timeMap[key] = new() {
                { timestamp, value }
            };
        }
    }

    public string Get(string key, int timestamp)
    {
        return this.timeMap[key].Where(x => x.Key <= timestamp).OrderByDescending(x => x.Key).FirstOrDefault().Value ?? "";
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
