using Leetcode.Linked_List._146_LRU_Cache;

namespace Leetcode.Tests.Linked_List;

public class _146_LRU_Cache
{
    [Fact]
    public void Test_1()
    {
        LRUCache cache = new(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        Assert.Equal(1, cache.Get(1));

        cache.Put(3, 3);
        Assert.Equal(-1, cache.Get(2));

        cache.Put(4, 4);
        Assert.Equal(-1, cache.Get(1));
        Assert.Equal(3, cache.Get(3));
        Assert.Equal(4, cache.Get(4));
    }
}
