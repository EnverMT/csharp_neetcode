﻿using Leetcode.Linked_List;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Leetcode;

public class Program
{
    static void Main()
    {
        
        Base _base = new();
        ListNode node = _base.GetListNodesFromArray([1, 2, 3, 4, 5]);

        int[] ints = _base.GetArrayFromList(node);

        Console.WriteLine(_base.ArrayToString(ints));
    }
}
