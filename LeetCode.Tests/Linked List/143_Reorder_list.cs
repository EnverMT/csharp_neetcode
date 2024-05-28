using Leetcode.Linked_List;
using Leetcode.Linked_List._143_Reorder_list;
using System.Text.Json;

namespace Leetcode.Tests.Linked_List;

public class _143_Reorder_list
{
    private readonly Solution _solution = new();
    private readonly Base _base = new();

    [Fact]
    public void LinkedList_143_Reorder_list()
    {
        _base.GetListNodesFromArray([1, 2, 3, 4, 5]);
        Console.WriteLine(JsonSerializer.Serialize(_base));
    }

}
