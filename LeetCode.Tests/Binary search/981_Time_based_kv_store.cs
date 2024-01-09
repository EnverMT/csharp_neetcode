using Leetcode.Binary_Search._981_Time_based_kv_store;

namespace Leetcode.Tests.Binary_search;

public class _981_Time_based_kv_store
{
    private readonly TimeMap timeMap;
    public _981_Time_based_kv_store()
    {
        timeMap = new TimeMap();
    }

    [Fact]
    public void BinarySearch_TimeMap_1()
    {
        timeMap.Set("foo", "bar", 1);
        Assert.Equal("bar", timeMap.Get("foo", 1));
        Assert.Equal("bar", timeMap.Get("foo", 3));

        timeMap.Set("foo", "bar2", 4);
        Assert.Equal("bar2", timeMap.Get("foo", 4));
        Assert.Equal("bar2", timeMap.Get("foo", 5));
    }
}
