using System.Collections.Generic;

public static class ValidParentheses
{
    public static bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length % 2 == 1)
        {
            return false;
        }

        var stack = new Stack<char>();

        foreach (char ch in s)
        {
            switch (ch)
            {
                case '(':
                    stack.Push(')');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                default:
                    if (stack.Count == 0 || stack.Pop() != ch)
                    {
                        return false;
                    }
                    break;
            }
        }

        return stack.Count == 0;
    }
}
