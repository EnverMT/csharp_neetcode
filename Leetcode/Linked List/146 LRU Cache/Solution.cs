namespace Leetcode.Linked_List._146_LRU_Cache;

public class LRUCache(int capacity)
{
    private readonly Dictionary<int, LRUNode> _hashmap = new();
    private readonly int _capacity = capacity;
    private LRUNode? _first = null;
    private LRUNode? _last = null;
    private int _size = 0;

    public int Get(int key)
    {
        _hashmap.TryGetValue(key, out LRUNode? node);

        if (node == null)
            return -1;

        MoveNodeToLast(node);

        return node.val;
    }

    public void Put(int key, int value)
    {
        // Update if exist
        if (_hashmap.ContainsKey(key))
        {
            _hashmap[key].val = value;
            MoveNodeToLast(_hashmap[key]);
            return;
        }

        LRUNode node = new(key, value);
        _hashmap.Add(key, node);

        if (_first == null)
            _first = node;

        if (_last != null)
        {
            _last.next = node;
            node.prev = _last;
        }

        _last = node;
        _size++;

        // Remove if overflow
        if (_size > _capacity)
        {
            int old = _first!.key;
            _first = _first.next;
            _first!.prev = null;

            _hashmap.Remove(old);
            _size--;
        }

        return;
    }

    private void MoveNodeToLast(LRUNode node)
    {
        if (node == _last)
            return;

        if (node == _first)
            _first = _first!.next;

        if (node.prev != null)
            node.prev.next = node.next;

        if (node.next != null)
            node.next.prev = node.prev;

        _last!.next = node;
        node.prev = _last;
        node.next = null;

        _last = node;
    }

    private class LRUNode(int key, int val)
    {
        public int key = key;
        public int val = val;
        public LRUNode? next = null;
        public LRUNode? prev = null;

        public override string ToString()
        {
            return $"({this.key},{this.val})";
        }
    }
}