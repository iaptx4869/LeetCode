public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++) 
        {
            char ch = s[i];
            if (ch == '(' || ch == '[' || ch == '{') stack.Push(ch);
            if (ch == ')' && (stack.Count == 0 || stack.Pop() != '('))
                                return false;
            if (ch == ']' && (stack.Count == 0 || stack.Pop() != '['))
                                return false;
            if (ch == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                                return false;
        }
        if (stack.Count != 0) return false;
        return true;
    }
}