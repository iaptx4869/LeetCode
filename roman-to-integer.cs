public class Solution
{
    public int RomanToInt(string s)
    {
        if (s == null || s.Length == 0) return 0;
        Hashtable ht = new Hashtable();
        ht.Add('I', 1);
        ht.Add('V', 5);
        ht.Add('X', 10);
        ht.Add('L', 50);
        ht.Add('C', 100);
        ht.Add('D', 500);
        ht.Add('M', 1000);
        int length = s.Length;
        int result = (int)ht[s[length - 1]];
        for (int i = length - 2; i >= 0; i--)
        {
            if ((int)ht[s[i + 1]] <= (int)ht[s[i]]) result += (int)ht[s[i]];
            else result -= (int)ht[s[i]];
        }
        return result;
    }
}
