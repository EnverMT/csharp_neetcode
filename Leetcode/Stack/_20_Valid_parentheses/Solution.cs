namespace Leetcode.Stack._20_Valid_parentheses;

public class Solution
{
    private Dictionary<string, string> validTags = new()
    {
        {"}","{"},
        {"]","["},
        {")","("}
    };
    private Stack<string> stack = new();

    public bool IsValid(string s)
    {
        foreach (char ch in s)
        {
            if (validTags.ContainsKey(ch.ToString()))
            {
                if (stack.Count > 0 && stack.Peek().Equals(validTags[ch.ToString()]))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(ch.ToString());
            }
        }
        return stack.Count == 0;
    }
}
